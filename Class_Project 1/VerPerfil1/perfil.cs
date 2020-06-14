using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerPerfil1
{
    public partial class perfil : Form
    {
        string Foto, Nom;

        public perfil(string NomUsuari, string FotoUsuari)
        {
            InitializeComponent();
            Nom = NomUsuari;
            Foto = FotoUsuari;
        }

        private void perfil_Load(object sender, EventArgs e)
        {
            label_nombre_usuario.Text = Nom;
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("./Resources/" + Foto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
