using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsPOO
{
    public partial class SpeedControl : UserControl
    {
        public SpeedControl()
        {
            InitializeComponent();
        }

        public void ChangeValueTextbox(string value)
        {
            textBox1.Text = value; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number;

            try
            {
                number = int.Parse(textBox1.Text);

                if (number >= 100000)
                {
                    pictureBox.Image = Properties.Resources.fast;
                }
                else
                {
                    pictureBox.Image = Properties.Resources.slow;
                }
            }
            catch (Exception)
            {
                pictureBox.Image = Properties.Resources.unknown;
            }
        }
    }
}
