using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EDI
{
    public partial class frmEdi : Form
    {
        string filePath;
        int idContact = 0;

        public frmEdi()
        {
            InitializeComponent();
        }

        private void button_selecionarFitxer_Click(object sender, EventArgs e)
        {
            OpenFileDialog EdiFile = new OpenFileDialog(); 

            EdiFile.Filter = " All files(*.*) |*.*| edi files(*.edi) |*.edi";
            EdiFile.FilterIndex = 2;
            EdiFile.RestoreDirectory = true;

            textBoxNotifications.Clear(); 

            if (EdiFile.ShowDialog() == DialogResult.OK)
            {
                filePath = EdiFile.FileName;
                textBox_fitxer.Text = filePath; 

                using (StreamReader fileReader = new StreamReader(EdiFile.FileName))
                {
                   textBoxNotifications.Text = fileReader.ReadToEnd(); 
                }
            }
            else
            {
                textBoxNotifications.Text = "ERROR: Seleciona un fitxer .EDI";
            }
        }

        private void button_stringFunctions_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                StreamReader fileReader = new StreamReader(filePath);

                string [] data;
                string    line = fileReader.ReadLine();

                

                edicovidEntities bbddEntities = new edicovidEntities();

                while (line != null)
                {
                    data = line.Split('|');

                    if (data[0] == "CON")
                    {
                        AddContact(data);
                    }
                    else
                    {
                        AddContactSystem(data); 
                    }
                    line = fileReader.ReadLine();
                }

                textBoxNotifications.Text = "Contactes afegits correctament (string functions)"; 
            }
            else
            {
                textBoxNotifications.Text = "ERROR: Afegeix un fitxer .EDI";
            }
        }

        private void button_Linq_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                List<string[]> contactsList = (
                        from listContacts
                        in File.ReadAllLines(filePath)
                        select listContacts.Split('|')
                    ).ToList();

                foreach (string[] data in contactsList)
                {
                    if (data[0] == "CON")
                    {
                        AddContact(data); 
                    }
                    else
                    {
                        AddContactSystem(data);
                    }
                }
                
                textBoxNotifications.Text = "Contactes afegits correctament (LINQ)";
            }
            else
            {
                textBoxNotifications.Text = "ERROR: Afegeix un fitxer .EDI";
            }
        }

    

        private void button_toXml_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                XmlWriter xml = XmlWriter.Create("Edi.xml");
                StreamReader documentReader; 

                List<string[]> contactsList = (
                       from listContacts
                       in File.ReadAllLines(filePath)
                       select listContacts.Split('|')
                   ).ToList();

                xml.WriteStartDocument();
                xml.WriteStartElement("customers");

                bool firstCostumer = true; 

                foreach (string[] data in contactsList)
                {
                    if (data[0] == "CON")
                    {

                        if (!firstCostumer)
                        {
                            xml.WriteEndElement();
                        }

                        xml.WriteStartElement("customer");
                        xml.WriteStartElement("name");
                        xml.WriteString(data[1]);
                        xml.WriteEndElement();
                        xml.WriteStartElement("birthdate");
                        xml.WriteString(data[2]);
                        xml.WriteEndElement();
                        xml.WriteStartElement("communication");
                        xml.WriteStartElement("type");
                        xml.WriteString("Móvil");
                        xml.WriteEndElement();
                        xml.WriteStartElement("value");
                        xml.WriteString(data[3]);
                        xml.WriteEndElement();
                        xml.WriteEndElement();

                        firstCostumer = false;
                    }
                    else
                    {
                        xml.WriteStartElement("communication");
                        xml.WriteStartElement("type");
                        xml.WriteString(data[1]);
                        xml.WriteEndElement();
                        xml.WriteStartElement("value");
                        xml.WriteString(data[2]);
                        xml.WriteEndElement();
                        xml.WriteEndElement();
                    } 
                }
                xml.Close();

                documentReader =  new StreamReader("Edi.xml");
                textBox_xml.Text = documentReader.ReadToEnd();
            }
            else
            {
                textBoxNotifications.Text = "ERROR: Afegeix un fitxer .EDI";
            }
        }
        private void AddContact(string[] data)
        {
            NewContact contact = new NewContact();
            ContactSystem contactSystem = new ContactSystem();

            edicovidEntities bbddEntities = new edicovidEntities();

            contact.Name = data[1];
            contact.BirthDate = data[2];

            contactSystem.Description = "Móvil";
            contactSystem.SystemValue = data[3];
            contactSystem.IdContact = contact.idContact;

            bbddEntities.NewContact.Add(contact);
            bbddEntities.ContactSystem.Add(contactSystem);
            bbddEntities.SaveChanges();

            idContact = contact.idContact;
        }

        private void AddContactSystem(string[] data)
        {
            ContactSystem contactSystem = new ContactSystem();

            edicovidEntities bbddEntities = new edicovidEntities();

            contactSystem.Description = data[1];
            contactSystem.SystemValue = data[2];
            contactSystem.IdContact = idContact;

            bbddEntities.ContactSystem.Add(contactSystem);
            bbddEntities.SaveChanges();
        }
    }
}
