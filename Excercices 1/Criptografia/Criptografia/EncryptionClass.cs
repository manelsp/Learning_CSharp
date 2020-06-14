using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Criptografia
{
    public class EncryptionClass
    {
        private UnicodeEncoding ByteConverter = new UnicodeEncoding();

        public RSACryptoServiceProvider rsa;

        public string PublicKey { get; set; }
        public void CreateKeys(string KeyContainerName, string rutePath)
        {
            CspParameters cspp = new CspParameters();

            cspp.KeyContainerName = KeyContainerName;

            // Això crea una clau publica i una privada
            rsa = new RSACryptoServiceProvider(cspp);

            // Guardem les claus en un xml 
            PublicKey = rsa.ToXmlString(false);

            File.WriteAllText(rutePath, PublicKey);
        }

        public void ImportRsa(string publicKeyRute)
        {           
            rsa = new RSACryptoServiceProvider();

            string xmlKey = File.ReadAllText(publicKeyRute);

            rsa.FromXmlString(xmlKey);
        }

        public string SelectRutePath()
        {
            // Prepare a dummy string, thos would appear in the dialog
            string dummyFileName = "publicKey.xml";
            string savePath = ""; 

            SaveFileDialog sf = new SaveFileDialog();
            // Feed the dummy name to the save dialog
            sf.FileName = dummyFileName;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                savePath = Path.GetDirectoryName(sf.FileName);
            }

            return savePath + '\\' + dummyFileName; 
        }

        public byte[] Encrypt(string plainText)
        {
            byte[] textToEncrypt = ByteConverter.GetBytes(plainText);
            byte[] encryptedData;

            encryptedData = rsa.Encrypt(textToEncrypt, false);

            return encryptedData;
        }

        public string Decrypt(byte[] EncryptedText)
        {
            byte[] decrpyedText = rsa.Decrypt(EncryptedText, false);

            return ByteConverter.GetString(decrpyedText);
        }

        public string ShowPublicKey()
        {
            return rsa.ToXmlString(false).ToString();
        }
    }
}

