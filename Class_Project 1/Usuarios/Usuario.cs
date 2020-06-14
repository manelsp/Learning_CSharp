using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Encriptacio;
using CrystalReports1;

namespace Usuarios
{
    public partial class Usuario : ProvaDades.General
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
           try
            {
                Form1 crt = new Form1(SWIDUser.Text);
                crt.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("selecciona usuari");
            }
        }
    }
}
