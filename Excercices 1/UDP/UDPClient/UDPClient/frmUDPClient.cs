using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPClient
{
    public partial class frmUDPClient : Form
    {
        UdpClient udpCli;

        private double y;
        private int x = 0; 

        public frmUDPClient()
        {
            InitializeComponent();
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            udpCli = new UdpClient();

            string serverName = textBox_Server.Text;
            string missatge = textBox_Missatge.Text;
            int port = Int32.Parse(textBox_Port.Text); 

            udpCli.Connect(serverName, port);
            Byte[] sendData = Encoding.ASCII.GetBytes(missatge);
            udpCli.Send(sendData, sendData.Length);

            udpCli.Close(); 
        }

        private void button_Data_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {   
            string missatge;
            string serverName = textBox_Server.Text;
            int port = Int32.Parse(textBox_Port.Text);

            udpCli = new UdpClient();
            udpCli.Connect(serverName, port);

            y = Math.Exp(x / 100.0);
            x++;

            if (x%50 == 0)
            {
                missatge = "X: " + x + " Y: " + y; 

                Byte[] sendData = Encoding.ASCII.GetBytes(missatge);
                udpCli.Send(sendData, sendData.Length);
            }

            if (x >= 1000)
            {
                missatge = "FINAL";
                
                timer.Stop();

                Byte[] sendData = Encoding.ASCII.GetBytes(missatge);
                udpCli.Send(sendData, sendData.Length);

                udpCli.Close(); 
            }
        }
    }
}
