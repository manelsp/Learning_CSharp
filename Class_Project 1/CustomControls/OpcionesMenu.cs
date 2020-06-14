using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CustomControls
{
    public partial class OpcionesMenu : UserControl
    {
        private string _NombreFormulari;
        private string _Descripcion;
        private string _Dll;
        private string _Imagen;
        private string _Rango;

        public string Rango
        {
            get { return _Rango; }
            set { _Rango = value; }
        }

        public string Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        public string Dll
        {
            get { return _Dll; }
            set { _Dll = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string NombreFormulari
        {
            get { return _NombreFormulari; }
            set { _NombreFormulari = value; }
        }

        public OpcionesMenu()
        {
            InitializeComponent();
        }

        private void OpcionesMenu_Load(object sender, EventArgs e)
        {
            LabelDescripcio.Text = Descripcion;
            Foto.ImageLocation = Application.StartupPath + "/Resources/" + Imagen;
        }

        private void Foto_Click(object sender, EventArgs e)
        {
            abrirForm();
        }

        private void abrirForm()
        {
            bool formAbierto = true;
            string nombreForm = Descripcion;

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.Name == nombreForm)
                {
                    formulario.BringToFront();
                }
                else
                {
                    formAbierto = false;
                }
            }

            if (!formAbierto)
            {
                Assembly ensamblado = Assembly.LoadFrom(Dll + ".dll");
                Object formulario;
                Type tipo;
                tipo = ensamblado.GetType(Dll + "." + NombreFormulari);
                formulario = Activator.CreateInstance(tipo);
                ((Form)formulario).TopLevel = false;

                foreach (Control panel in this.Parent.Parent.Parent.Controls)
                {
                    if (panel.Name == "Main_panel")
                    {
                        foreach (Control panel2 in panel.Controls)
                        {
                            if (panel2.Name == "panel1")
                            {
                                panel2.Controls.Add((Form)formulario);

                                ((Form)formulario).Show();
                                ((Form)formulario).BringToFront();
                            }
                        }
                    }
                }
            }
        }

        private void LabelDescripcio_Click(object sender, EventArgs e)
        {
            abrirForm();
        }
    }
}
