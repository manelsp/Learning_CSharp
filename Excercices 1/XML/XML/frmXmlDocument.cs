using System;
using System.Windows.Forms;
using System.Xml;

namespace XML
{
    public partial class frmXmlDocument : Form
    {
        public frmXmlDocument()
        {
            InitializeComponent();
        }

        private void button_activitat1_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            XmlNode root = xml.CreateElement("troops");

            xml.AppendChild(root);

            richTextBox.Clear(); 

            XmlNode destacament =   xml.CreateElement("destacament");
            XmlAttribute nameAttribute = xml.CreateAttribute("name");
            nameAttribute.Value = "Naboo Central";
            destacament.Attributes.Append(nameAttribute);
            root.AppendChild(destacament);

            XmlNode stormtrooper = xml.CreateElement("stormtrooper");
            destacament.AppendChild(stormtrooper);

            XmlNode name = xml.CreateElement("name");
            name.InnerText = "AXZ-998";
            stormtrooper.AppendChild(name);

            XmlNode rank = xml.CreateElement("rank");
            rank.InnerText = "Captain";
            stormtrooper.AppendChild(rank);

            xml.Save("Activitat1.xml");

            richTextBox.AppendText(xml.OuterXml);
        }

        private void button_activitat2_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            XmlNodeList list;
            XmlNode   troops;

            richTextBox.Clear();

            xml.Load("troops.xml");

            troops = xml.SelectSingleNode("troops");

            richTextBox.AppendText("Sistema 1");
            richTextBox.AppendText("\n ______________________________________________ \n\n");

            foreach (XmlNode xmlNode in troops.ChildNodes)
            {
                foreach (XmlNode xmlNodeChild in xmlNode.ChildNodes)
                {
                    if (xmlNodeChild.Name.ToLower() == "squadron")
                    {
                        richTextBox.AppendText(xmlNodeChild.InnerText);
                    }
                }
            }
            
            list = xml.GetElementsByTagName("troops");

            richTextBox.AppendText("\n\n Sistema 2");
            richTextBox.AppendText("\n ______________________________________________ \n\n");

            foreach (XmlNode xmlNode in list)
            {
                foreach (XmlNode xmlNodeChild in xmlNode)
                {
                    foreach (XmlNode xmlNodeChilChild in xmlNodeChild)
                    {
                        if (xmlNodeChilChild.Name.ToLower() == "squadron")
                        {
                            richTextBox.AppendText(xmlNodeChilChild.InnerText);
                        }
                    }
                }
            }
        }

        private void button_Activitat3_Click(object sender, EventArgs e)
        {
            XmlNodeList list; 
            XmlDocument xml = new XmlDocument();

            xml.Load("troops.xml");

            list = xml.GetElementsByTagName("troops");

            richTextBox.Clear();

            richTextBox.AppendText("Nodes recursivament");
            richTextBox.AppendText("\n ______________________________________________ \n");

            foreach (XmlNode xmlNode in list)
            {
                    richTextBox.AppendText("\n" + xmlNode.Name); 

                foreach (XmlNode xmlNodeChild in xmlNode.ChildNodes)
                {
                        richTextBox.AppendText("\n" + xmlNodeChild.Name);

                    foreach (XmlNode xmlNodeChild2 in xmlNodeChild.ChildNodes)
                    {
                        if (xmlNodeChild2.NodeType == XmlNodeType.Element)
                        {
                            richTextBox.AppendText("\n" + xmlNodeChild2.Name);
                        }

                        foreach (XmlNode xmlNodeChild3 in xmlNodeChild2.ChildNodes)
                        {
                                richTextBox.AppendText("\n" + xmlNodeChild3.Name);

                            foreach (XmlNode xmlNodeChild4 in xmlNodeChild3.ChildNodes)
                            {
                                    richTextBox.AppendText("\n" + xmlNodeChild4.Name); 
                            }
                        }
                    }
                }
            }
        }

        private void button_activitat4_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            XmlNode nameNode;
            XmlElement nameElement; 

            xml.LoadXml(
                    "<stormtrooper>" +
                        "<name>BBB-222</name>" +
                        "<rank>Liutenant</rank>" +
                    "</stormtrooper>"
                );

            richTextBox.Clear();

            richTextBox.AppendText("XML original ---------- \n");
            richTextBox.AppendText(xml.OuterXml + "\n\n");

            nameNode = xml.SelectSingleNode("stormtrooper");
            nameElement = xml.CreateElement("nom");

            nameElement.InnerText = "AAA-111";

            nameNode.ReplaceChild(nameElement, nameNode.FirstChild);

            richTextBox.AppendText("XML modificat --------- \n");
            richTextBox.AppendText(xml.OuterXml);
        }

        private void button_Activitat5_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            XmlNode troopsNode;
            XmlAttribute nameAttribute, codeAttribute;
            XmlElement destacamentNode; 

            xml.Load("troops.xml");

            troopsNode = xml.SelectSingleNode("troops");
            
            destacamentNode = (XmlElement)xml.SelectSingleNode("//destacament");
            destacamentNode.SetAttribute("Code", "AAAA");

            nameAttribute = destacamentNode.GetAttributeNode("name");

            codeAttribute = destacamentNode.GetAttributeNode("Code");

            richTextBox.Clear();
            
            richTextBox.AppendText("Atributs originals --------- \n\n");
            richTextBox.AppendText(nameAttribute.Name + "=" + nameAttribute.Value + "\n");
            richTextBox.AppendText(codeAttribute.Name + "=" + codeAttribute.Value + "\n\n");

            destacamentNode.SetAttribute("name", "1111");
            destacamentNode.SetAttribute("Code", "1111");

            richTextBox.AppendText("Atributs modificat --------- \n\n");
            richTextBox.AppendText(nameAttribute.Name + "=" + nameAttribute.Value + "\n");
            richTextBox.AppendText(codeAttribute.Name + "=" + codeAttribute.Value + "\n");
        }
    }
}
