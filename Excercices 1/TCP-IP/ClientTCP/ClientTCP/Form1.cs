using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClientTCP
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient;
        
        Thread thread; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadXmlValues();
        }

        private void buttonComprovarXarxa_Click(object sender, EventArgs e)
        {
            panelColorStatus.BackColor = Color.Orange;
            listBoxNotificaciones.Items.Clear();

            thread = new Thread(CheckNetwork);

            thread.Start();
        }

        private void buttonEnviarMissatge_Click(object sender, EventArgs e)
        {
            thread = new Thread(SendText);

            listBoxNotificaciones.Items.Clear();

            thread.Start(); 
        }

        private void ReadXmlValues()
        {
            XElement xmlFile = XElement.Load("./TCPSettings.xml");

            IEnumerable<XElement> query = from x
                                          in xmlFile.Elements("Protocol").Elements("TCP")
                                          select x;

            foreach (XElement item in query)
            {
                textBoxIp.Text   = item.Element("IP").Value;
                textBoxPort.Text = item.Element("Port").Value;
            }
        }

        private void buttonConfiguracio_Click(object sender, EventArgs e)
        {
            XElement xmlFile = XElement.Load("./TCPSettings.xml");

            listBoxNotificaciones.Items.Clear();

            IEnumerable<XElement> query = from x 
                                          in xmlFile.Elements("Protocol").Elements("TCP") 
                                          select x;
           
            foreach (XElement item in query)
            {
                item.SetElementValue("IP", textBoxIp.Text.Trim());
                item.SetElementValue("Port", textBoxPort.Text.Trim());
            }

            if (textBoxIp.Text.Length > 0 && textBoxPort.Text.Length > 0)
            {
                xmlFile.Save("./TCPSettings.xml");

                listBoxNotificaciones.Items.Add("S'ha guardat la configuració");
                listBoxNotificaciones.ForeColor = Color.Lime;
            }
            else
            {
                listBoxNotificaciones.Items.Add("ERROR, esciru un port i una ip");
                listBoxNotificaciones.ForeColor = Color.Red;
            }
        }

        private void CheckNetwork()
        {
            bool networkConnection;
            bool checkPing = true; 

            Ping ping = new Ping();

            networkConnection = NetworkInterface.GetIsNetworkAvailable(); 

            if (networkConnection)
            {
                listBoxNotificaciones.ForeColor = Color.Lime;

                listBoxNotificaciones.Invoke((MethodInvoker)delegate
                {
                    listBoxNotificaciones.Items.Add("Comprovant connexió");
                    listBoxNotificaciones.Items.Add("-------------------");
                });

                for (int i = 1; i <= 10; i++)
                {
                    PingReply reply = ping.Send("127.0.0.1", 6688);

                    if (reply != null)
                    {
                        listBoxNotificaciones.Invoke((MethodInvoker)delegate
                        {
                            listBoxNotificaciones.Items.Add("ping " + reply.Status + " " + reply.Address);

                            if (reply.Status.ToString() == "TimedOut")
                            {
                                listBoxNotificaciones.ForeColor = Color.Red;

                                panelColorStatus.BackColor = Color.Red;

                                labelConnectionStatus.Text = "ERROR, ping TimedOut";

                                checkPing = false; 
                            }
                            else
                            {
                                listBoxNotificaciones.ForeColor = Color.Lime;
                            }
                        });
                    }
                }

                if (checkPing)
                {
                    labelConnectionStatus.Invoke((MethodInvoker)delegate
                    {
                        labelConnectionStatus.Text = "   Connexió correcta";
                    });

                    listBoxNotificaciones.ForeColor = Color.Lime;

                    panelColorStatus.BackColor = Color.Lime;

                    buttonEnviarMissatge.Invoke((MethodInvoker)delegate
                    {
                        buttonEnviarMissatge.Enabled = true;
                    });
                }     
            }
            else
            {
                listBoxNotificaciones.Items.Add("ERROR, no hi ha connexió");
                panelColorStatus.BackColor = Color.Red;

                buttonEnviarMissatge.Enabled = false;

                labelConnectionStatus.Text = "  Xarxa no disponible";
                listBoxNotificaciones.ForeColor = Color.Red;
            }
        }

        private void SendText()
        {
            string ipClient = textBoxIp.Text;

            int portClient = Int32.Parse(textBoxPort.Text); ;

            byte[] messageBytes;

            NetworkStream networkStream;

            try
            {
                tcpClient = new TcpClient(ipClient, portClient);

                if (tcpClient.Connected)
                {
                    if (textBoxMissatge.Text.Length > 0)
                    {
                        messageBytes = Encoding.ASCII.GetBytes(textBoxMissatge.Text);

                        networkStream = tcpClient.GetStream();
                        networkStream.Write(messageBytes, 0, textBoxMissatge.Text.Length);

                        listBoxNotificaciones.Invoke((MethodInvoker)delegate
                        {
                            listBoxNotificaciones.Items.Add("Missatge enviat: " + textBoxMissatge.Text);
                        });
                        
                        listBoxNotificaciones.ForeColor = Color.Lime;

                        buttonDesconnectar.Invoke((MethodInvoker)delegate
                        {
                            buttonDesconnectar.Enabled = true;
                        });

                        textBoxMissatge.Invoke((MethodInvoker)delegate
                        {
                            textBoxMissatge.Text = "";
                        });
                    }
                    else
                    {
                        listBoxNotificaciones.Invoke((MethodInvoker)delegate
                        {
                            listBoxNotificaciones.Items.Add("ERROR, Escriu un missatge");
                        });

                        listBoxNotificaciones.ForeColor = Color.Red;
                    }
                }
                else
                {
                    listBoxNotificaciones.Invoke((MethodInvoker)delegate
                    {
                        listBoxNotificaciones.Items.Add("ERROR, No s'ha trobat el servidor");
                    });

                    listBoxNotificaciones.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                listBoxNotificaciones.Invoke((MethodInvoker)delegate
                {
                    listBoxNotificaciones.Items.Add("ERROR, Encèn el servidor TCP");
                });
                listBoxNotificaciones.ForeColor = Color.Red;
            }
        }

        private void buttonDesconnectar_Click(object sender, EventArgs e)
        {
            buttonDesconnectar.Enabled = false;

            tcpClient.Close();
            thread.Abort(); 
        }
    }
}
