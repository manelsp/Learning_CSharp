using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte1
{
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ProgresoDeCarga(); 
        }

        private void ProgresoDeCarga()
        {
            progressBar.Increment(1);

            label_porcentajeCargado.Text = progressBar.Value.ToString() + "%";

            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Stop();
                this.Hide();

                Form_Login Login = new Form_Login();

                Login.Show(); 
            }
        }
    }
}
