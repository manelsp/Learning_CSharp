using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Planets;
using Priority;
using ProvaDades;
using CustomControls;
using VerPerfil1;
using CrystalReports1;

namespace Projecte1
{
    public partial class Form_MainForm : Form
    {
        bool openProfile = false;
        string Nom, Foto, ID, Acces;
        public Form_MainForm(string IDUsuari, string NomUsuari, string FotoUsuari, string NivellAccess)
        {
            InitializeComponent();
            Nom = NomUsuari;
            Foto = FotoUsuari;
            ID = IDUsuari;
            Acces = NivellAccess;
        }

        //CLOSE BUTTON EVENTS
        private void Close_button_MouseMove(object sender, MouseEventArgs e)
        {
            Close_button.BackgroundImage = Main.Resources.RedClose_Icon;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.BackgroundImage = Main.Resources.Close_Icon;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_MainForm_Load(object sender, EventArgs e)
        {
            CrearOpcionesMenuLateral();
            label_nombre_usuario.Text = Nom;
            pictureBoxusuarios.ImageLocation = System.IO.Path.GetFullPath("./Resources/" + Foto);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_button_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else {

                this.WindowState = FormWindowState.Normal;
            }

        }

        private void pictureBox_menu_Click(object sender, EventArgs e)
        {
            LeftMenu_panel.Visible = !LeftMenu_panel.Visible;
        }

        private void pictureBox_tresbotones_Click(object sender, EventArgs e)
        {
            panel_Botones.Visible = !panel_Botones.Visible;
        }

        private void button_CerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login login = new Form_Login();
            login.Show();
        }

        private void button_VerPerfil_Click(object sender, EventArgs e)
        {
            string query = "SELECT * " +
                           "FROM USERS " +
                           "WHERE IDUSER = " + ID;

            AccesDades.ADO bd = new AccesDades.ADO();
            DataSet dts = bd.PortaDades(query);

            perfil perfil1 = new perfil(dts.Tables[0].Rows[0][2].ToString(), dts.Tables[0].Rows[0][7].ToString());

            perfil1.TopLevel = false;
            panel1.Controls.Add(perfil1);

            perfil1.Show();
        }

        private void CrearOpcionesMenuLateral()
        {
            string query = "SELECT * " +
                          "FROM FORMS " +
                          "WHERE RANGO <= " + Acces;

            DataSet dataset;
            AccesDades.ADO Connection = new AccesDades.ADO();

            dataset = Connection.PortaDades(query);

            foreach (DataRow datarow in dataset.Tables[0].Rows)
            {
                OpcionesMenu opcionesMenu = new OpcionesMenu
                {
                    Dock = DockStyle.Top,

                    NombreFormulari = datarow["nom"].ToString(),
                    Descripcion = datarow["descripcio"].ToString(),
                    Dll = datarow["dll"].ToString(),
                    Imagen = datarow["image"].ToString(),
                    Rango = datarow["rango"].ToString(),
                };

                PanelOpciones.Controls.Add(opcionesMenu);
            }
        }
    }
}
