using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularExpresions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ipcA = "^(\\d|[1-9]\\d|[1][0-2][0-7])\\.((\\d|\\d\\d|[1]\\d\\d|[2][0-5][0-5])\\.){2}(\\d|\\d\\d|[1]\\d\\d|[2][0-5][0-5])(\\:\\d{1,4})$";
            string telf = "^([(]\\+\\d{1,3}[)]|\\+\\d{1,3})\\-(\\d{3})\\.((\\d{2})\\.){2}(\\d{2})$";
            string mail = "^([a-z]\\w*\\.\\w*\\@[a-z]\\w*\\.[a-z]{2,3})$";
            string stWo = "^([BCDFGHIJKLMNPQRSVWXZ]{4}\\-\\d{3}\\\\[13579][AEIOU])$";

            textBox_Regex_Ip.Text       = ipcA;
            textBox_Regex_Mobil.Text    = telf;
            textBox_Regex_Email.Text    = mail;
            textBox_Regex_StarWars.Text = stWo;
        }

        private void button_Ip_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox_Ip.Text, textBox_Regex_Ip.Text))
            {
                panel_Ip.BackColor = Color.Green; 
            }
            else
            {
                panel_Ip.BackColor = Color.Red;
            }
        }

        private void button_Mobil_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox_Mobil.Text, textBox_Regex_Mobil.Text))
            {
                panel_Mobil.BackColor = Color.Green;
            }
            else
            {
                panel_Mobil.BackColor = Color.Red;
            }
        }

        private void button_Email_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox_Email.Text, textBox_Regex_Email.Text))
            {
                panel_Email.BackColor = Color.Green;
            }
            else
            {
                panel_Email.BackColor = Color.Red;
            }
        }

        private void button_StarWars_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox_StarWars.Text, textBox_Regex_StarWars.Text))
            {
                panel_StarWars.BackColor = Color.Green;
            }
            else
            {
                panel_StarWars.BackColor = Color.Red;
            }
        }
    }
}
