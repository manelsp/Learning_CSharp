using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using System.Data.SqlClient;
using Encriptacio;

namespace ProvaDades
{
    public partial class General : Form
    {
        DataSet dades;
        AccesDades.ADO bd = new AccesDades.ADO();

        private string query;
        private bool insertar; 
        private string _Taula;
        private string _BuscarPer;

        public string BuscarPer 
        {
            get { return _BuscarPer; }
            set { _BuscarPer = value; }
        }

        public string Taula
        {
            get { return _Taula; }
            set { _Taula = value; }
        }

        public General()
        {
            InitializeComponent();
        }

        private void General_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return; 

            query = "SELECT * " +
                    "FROM " + Taula;
            bd.Connectar();
            dades = bd.PortarTaula(Taula);
            dataGridView1.DataSource = dades.Tables[0];
            Label_Taula.Text = Taula;            

            //carreguem els comboboxs
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWCombobox))
                {
                    ((SWCombobox)ctr).CarregaCombo();
                }
            }

            DataBinding();
        }

        private void pictureBox_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                dataGridView1.Width = 1350;
                dataGridView1.Height = 725;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                dataGridView1.Width = 946;
                dataGridView1.Height = 221;
            }
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataBinding()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    
                    ctr.DataBindings.Clear();
                    ctr.DataBindings.Add("Text", dades.Tables[0], ((SWTextbox)ctr).CampoBD);
                    ctr.Validated += new EventHandler(ValidarText);
                }
            }
        }

        private void ValidarText(object sender, EventArgs e)
        {
            if (!insertar)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.GetType() == typeof(SWTextbox))
                    {
                        if (ctrl.Name == "SWPassword")
                        {
                            Encriptar E = new Encriptar();

                            ctrl.Text = E.GenerarHash(ctrl.Text.Trim());
                        }
                    }
                }

                ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void BorrarDataBinding()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.DataBindings.Clear();
                }
            }
        }

        private void button_GuardarCambios_Click(object sender, EventArgs e)
        {
            if (insertar)
            {
                DataRow newrow = dades.Tables[0].NewRow();

                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(SWTextbox))
                    {
                       newrow[((SWTextbox)ctr).CampoBD] = ((SWTextbox)ctr).Text;
                    }
                }

                dades.Tables[0].Rows.Add(newrow);

                insertar = false;
            }

            bd.Actualitzar(query, dades);
            dades = bd.PortarTaula(Taula);
            dataGridView1.DataSource = dades.Tables[0];
            DataBinding();

            MessageBox.Show("Taula actualitzada");
            button_Insertar.Enabled = true;
        }

        private void button_Insertar_Click(object sender, EventArgs e)
        {
            insertar = true;
            BorrarDataBinding();

            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.Text = "";
                }
            }
            MessageBox.Show("Escriu els valors i guarda els canvis");
            button_Insertar.Enabled = false;
        }
       
        private void textBox_Buscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBox_Buscar.Text;

            string query = "SELECT * " +
                           "FROM "+ Taula +
                           " WHERE " + BuscarPer + 
                           " LIKE UPPER('%" + busqueda + "%')";

            try
            {
                dades = bd.PortaDades(query);
                dataGridView1.DataSource = dades.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar");
            }
        }
    }
}
