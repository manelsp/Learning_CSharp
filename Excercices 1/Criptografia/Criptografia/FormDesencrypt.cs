using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Criptografia
{
    public partial class Desencriptar : Form
    {
        EncryptionClass encryption = new EncryptionClass();
        
        private string rutePath = string.Empty;
        public byte [] encryptedTextBytes; 

        public Desencriptar()
        {
            InitializeComponent();
        }

        private void buttonSelecionarRuta_Click(object sender, EventArgs e)
        {
            rutePath = encryption.SelectRutePath();

            textBoxFitxerXMLpublickey.Text = rutePath; 
        }

        private void buttonGenerarClaus_Click(object sender, EventArgs e)
        {
            string keyContainerName = textBoxNomKeycontainer.Text;

            labelAlerts.Visible = true; 

            if (rutePath == null || keyContainerName == "")
            {
                labelAlerts.ForeColor = Color.Red;
                labelAlerts.Text = "Especifica una ruta i escriu un nom pel container";
            }
            else
            {
                encryption.CreateKeys(keyContainerName, rutePath);

                labelAlerts.ForeColor = Color.Green;
                labelAlerts.Text = "Keys creades correctament";

                FormEncrypt formEncrypt = new FormEncrypt();
                formEncrypt.Show();
                formEncrypt.BringToFront(); 
            }
        }

        private void buttonDesencriptar_Click(object sender, EventArgs e)
        {
            string decryptedText;

            if (textBoxMissatgeEncriptat.Text.Length > 0)
            {
                decryptedText = encryption.Decrypt(encryptedTextBytes);

                textBoxMissatgeOriginal.Text = decryptedText;
            }
            else
            {
                labelAlerts.Text = "Encripta un missatges abans";
                labelAlerts.Visible = true; 
            }
        }
    }
}
