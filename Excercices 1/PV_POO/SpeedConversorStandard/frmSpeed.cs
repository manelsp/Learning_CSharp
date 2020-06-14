using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedConversorStandard
{
    public partial class frmSpeed : Form
    {
        public Calculus calculus = new Calculus();
        public frmSpeed()
        {
            InitializeComponent();
        }

        private void button_convertSpeed_Click(object sender, EventArgs e)
        {
            int parsecs = 0;
            int kms; 

            try
            {
                parsecs = int.Parse(textBox_parsecs.Text);
            }
            catch (Exception)
            {
   
            }

            kms = calculus.SpeedConversion(parsecs);

            speedControl.ChangeValueTextbox(kms.ToString());
        }
    }
}
