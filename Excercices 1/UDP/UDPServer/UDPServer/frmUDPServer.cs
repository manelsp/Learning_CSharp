using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPServer
{
    public partial class frmUDPServer : Form
    {
        UdpClient udpServer;
        Thread thread; 
        public frmUDPServer()
        {
            InitializeComponent();
        }

        private void button_Connecta_Click(object sender, EventArgs e)
        {
            string regexPort = "^(\\d{1,})$";
            
            if (Regex.IsMatch(textBox_Port.Text, regexPort))
            {
                int port = Int32.Parse(textBox_Port.Text);

                udpServer = new UdpClient(port);

                listBox.ForeColor = Color.Black;

                label_Estat.ForeColor = Color.Green;
                label_Estat.Text = "Connectat";

                thread = new Thread(UPDListening);

                try
                {
                    thread.Start(); 
                }
                catch (Exception)
                {
                    thread.Abort();
                }
            }
            else
            {
                listBox.ForeColor = Color.Red; 

                listBox.Items.Add("ERROR: Afegeix un port valid");

                label_Estat.ForeColor = Color.Red;
                label_Estat.Text = "Desconnectat";
            }
        }

        private void button_Tancar_Click(object sender, EventArgs e)
        {
            udpServer.Close();
            thread.Abort();

            label_Estat.ForeColor = Color.Red;
            label_Estat.Text = "Desconnectat";
        }

        private void UPDListening()
        {
            while (true)
            {
                IPEndPoint IeP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] BytesIn = udpServer.Receive(ref IeP);
                string returnData = Encoding.ASCII.GetString(BytesIn);

                listBox.Invoke((MethodInvoker)delegate
                {
                    listBox.Items.Add(IeP.Address + ":" + " " + returnData);
                });
            }
        }
    }
}
