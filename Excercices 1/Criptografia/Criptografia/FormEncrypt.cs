using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Criptografia
{
    public partial class FormEncrypt : Form
    {
        EncryptionClass encryption = new EncryptionClass();
        
        byte[] encryptedData;


        public FormEncrypt()
        {
            InitializeComponent();
        }
        private void buttonObtenirClau_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath    = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    encryption.ImportRsa(filePath);
                }
            }
        }

        private void buttonEncriptar_Click(object sender, EventArgs e)
        {
            string text = textBoxMissatgeOriginal.Text;
            string encryptedDataText;

            if (encryption.rsa == null)
            {
                labelAlerts.Text = "Importa una clau";
                labelAlerts.Visible = true; 
            }
            else
            {
                UnicodeEncoding byteConverter = new UnicodeEncoding();

                encryptedData = encryption.Encrypt(text);
                encryptedDataText = byteConverter.GetString(encryptedData);

                textBoxMissatgeEncriptat.Text = encryptedDataText;
            }
        }

        private void buttonMostrarClau_Click(object sender, EventArgs e)
        {
            string publicKey;

            if (encryption.rsa == null)
            {
                labelAlerts.Text = "Importa un clau";
                labelAlerts.Visible = true; 
            }
            else
            {
                publicKey = encryption.ShowPublicKey();
                textBoxMostrarClau.Text = publicKey;
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();

            if (textBoxMissatgeEncriptat.Text == "")
            {
                labelAlerts.Text = "Encripta un missatge";
                labelAlerts.Visible = true; 
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "Desencriptar")
                    {
                        ((Desencriptar)form).encryptedTextBytes = encryptedData;

                        foreach (Control control in form.Controls)
                        {
                            if (control.Name == "textBoxMissatgeEncriptat")
                            {
                                control.Text = byteConverter.GetString(encryptedData);
                            }
                        }
                    }
                }
            }
        }
    }
}
