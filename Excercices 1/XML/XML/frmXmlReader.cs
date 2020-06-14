using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace XML
{
    public partial class frmXmlReader : Form
    {
        XmlDocument xml = new XmlDocument();
        XmlNode root;

        XmlNodeList list;

        int numList = 1;

        string filePath = "";

        public frmXmlReader()
        {
            InitializeComponent();
        }

        private void frmXmlReader_Load(object sender, EventArgs e)
        {
            xml.Load("troops.xml");
            root = xml.DocumentElement;
        }
        private void button_RecorrerXML_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            ReadXml(root);
        }

        private void button_LlegirElements_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            string element = textBox_Element.Text;
            string atribut = textBox_Atribut.Text;

            numList = 1;

            list = xml.GetElementsByTagName(element);

            if (list.Count > 0)
            {
                listBox.Items.Add(list[0].NodeType + ": " + list[0].Name + " " + list[0].InnerXml);

                button_Next.Enabled = true;
            }
        }

        private void ReadXml(XmlNode root)
        {
            if (root is XmlElement)
            {
                listBox.Items.Add(root.NodeType + ": " + root.Name);

                if (root.Attributes.Count > 0)
                {
                    listBox.Items.Add("   Atribut: " + root.Attributes[0].Name + " - " + root.Attributes[0].Value);
                }

                if (root.HasChildNodes)
                {
                    ReadXml(root.FirstChild);
                }

                if (root.NextSibling != null)
                {
                    ReadXml(root.NextSibling);
                }
            }
            else if (root is XmlText)
            {
                listBox.Items.Add("   " + root.NodeType + ": " + root.Value);
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            string element = textBox_Element.Text;

            list = xml.GetElementsByTagName(element);

            if (list.Count > numList)
            {
                listBox.Items.Add(list[numList].NodeType + ": " + list[numList].Name + " " + list[numList].InnerXml);

                numList++;
            }
            else
            {
                button_Next.Enabled = false;
            }
        }

        private void button_Validar_Click(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();

            listBox.Items.Clear();

            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.DTD;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

            XmlReader reader;

            try
            {
                reader = XmlReader.Create(filePath, settings);
                
                while (reader.Read())
                {

                }
                if (listBox.Items.Count == 0)
                {
                    listBox.Items.Add("Procés Finalitzat: Validació DTD Correcta");
                }
            }
            catch (Exception)
            {
                listBox.Items.Add("ERROR: Afegeix un fitxer .xml");
            }
        }

        private void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            listBox.Items.Add("ERROR: " + e.Message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filePath = "";
            using (OpenFileDialog Dialog = new OpenFileDialog())
            {
                Dialog.InitialDirectory = Application.StartupPath;
                //Dialog.Filter = "XML Files (.xml)|.xml";
                Dialog.FilterIndex = 0;
                Dialog.DefaultExt = "xml";
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = Dialog.FileName;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "stormtrooper.xml";

            XmlWriterSettings settings = new XmlWriterSettings();
           
            XmlWriter writer = XmlWriter.Create(filePath, settings);

            settings.Indent = true;
            settings.IndentChars = "\t";


            writer.WriteStartDocument();
            writer.WriteComment("Dades del Soldat");
            writer.WriteStartElement("stoormtroopers");
            writer.WriteStartElement("stoormtrooper");
            writer.WriteAttributeString("id", "1");
            writer.WriteStartElement("generalData");
            writer.WriteElementString("name", "XVF-667");
            writer.WriteElementString("Rank", "Captain");
            writer.WriteEndElement();
            writer.WriteStartElement("destinationData");
            writer.WriteElementString("Planet", "Naboo");
            writer.WriteStartElement("Destacament");
            writer.WriteAttributeString("code", "NACR");
            writer.WriteValue("Naboo Central");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            listBox.Items.Clear();
            listBox.Items.Add("Stormtrooper.xml creat correctament");
        }
    }
} 
