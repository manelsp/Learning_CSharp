using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorTCP
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener = null;
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnectar_Click(object sender, EventArgs e)
        {
            int port;

            if (textBoxPort.Text.Length > 0 && Int32.TryParse(textBoxPort.Text, out int result))
            {
                buttonConnectar.Enabled = false;
                buttonDesconnectar.Enabled = true;

                textBoxPort.Enabled = false;

                port = Int32.Parse(textBoxPort.Text);

                tcpListener = new TcpListener(IPAddress.Any, port);
                thread = new Thread (ServerListening);

                listBoxMissatges.ForeColor = Color.Black;
                listBoxMissatges.Items.Clear();

                try
                {
                    tcpListener.Start(); 
                }
                catch (Exception exc)
                {
                    tcpListener.Stop();
                    thread.Abort();
                    MessageBox.Show(exc.Message);
                }
                thread.Start(); 
            }
            else
            {
                listBoxMissatges.ForeColor = Color.Red; 
                listBoxMissatges.Items.Add("ERROR, Escriu un port valid");
            }
        }

        private void ServerListening()
        {
            bool listening = true;
            
            string message;
            
            int bytesMessage;

            byte[] answerData = new Byte[256]; 

            while (listening)
            {
                if (tcpListener.Pending())
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    NetworkStream networkStream = tcpClient.GetStream();

                    bytesMessage = networkStream.Read(answerData, 0, answerData.Length);

                    message = Encoding.ASCII.GetString(answerData, 0, bytesMessage);

                    listBoxMissatges.Invoke((MethodInvoker)delegate
                    {
                        listBoxMissatges.Items.Add(message);
                    });
                }
            }
        }

        private void buttonDesconnectar_Click(object sender, EventArgs e)
        {
            buttonConnectar.Enabled = true;
            buttonDesconnectar.Enabled = false;

            textBoxPort.Enabled = true; 

            tcpListener.Stop();
            thread.Abort(); 
        }
    }
}
