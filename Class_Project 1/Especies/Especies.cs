using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Especies_ORM;
using CustomControls; 

namespace Especies
{
    public partial class Especies : Form
    {
        public static EstrellaDamEntities BaseDatos = new EstrellaDamEntities();

        public Especies()
        {
            InitializeComponent();
        }

        private void Especies_Load(object sender, EventArgs e)
        {
            labelInfo.Text = ""; 
            SelectAllEspecies();
            DataBinding();
        }

        public void SelectAllEspecies()
        {
            var especies =
                 (from p in BaseDatos.Species
                  select p
                 ).ToList();
            dataGridView1.DataSource = especies.ToList();
        }

        public void DataBinding()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType()==typeof(SWTextbox))
                {
                    ((SWTextbox)ctrl).DataBindings.Clear();
                    ((SWTextbox)ctrl).DataBindings.Add("Text", dataGridView1.DataSource, ((SWTextbox)ctrl).CampoBD); 
                }
            }
        }

        private void textBox_Buscar_TextChanged(object sender, EventArgs e)
        {
            var especies =
             (from p in BaseDatos.Species
              where p.CodeSpecie.Contains(textBox_Buscar.Text)
              select p
             ).ToList();
            dataGridView1.DataSource = especies.ToList();
        }

        private void button_Insertar_Click(object sender, EventArgs e)
        {
            swTextbox1.Clear();
            swTextbox2.Clear();

            labelInfo.Text = "*Introduce los datos y guarda los cambios";
        }

        private void button_GuardarCambios_Click(object sender, EventArgs e)
        {   
            //TODO Guardar cambios
        }
    }
}
