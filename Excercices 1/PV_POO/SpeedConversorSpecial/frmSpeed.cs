using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpeedConversorSpecial
{
    public partial class frmSpeed : SpeedConversorStandard.frmSpeed
    {
        public frmSpeed()
        {
            InitializeComponent();
        }

        private void buttonXwings_Click(object sender, EventArgs e)
        {
            int kms, parsecs;

            parsecs = ReadParsecs();

            kms = calculus.SpeedConversion(parsecs, "XW");

            speedControl.ChangeValueTextbox(kms.ToString());
        }

        private void buttonCargoShuttle_Click(object sender, EventArgs e)
        {
            int kms, parsecs;

            parsecs = ReadParsecs(); 

            kms = calculus.SpeedConversion(parsecs, "CS");

            speedControl.ChangeValueTextbox(kms.ToString());
        }

        private int ReadParsecs()
        {
            int parsecs = 0;

            try
            {
                parsecs = int.Parse(textBox_parsecs.Text);
            }
            catch (Exception)
            {

            }

            return parsecs; 
        }

        private void buttonUnknowRegions_Click(object sender, EventArgs e)
        {
            int kms, parsecs;

            parsecs = ReadParsecs();

            kms = calculus.SpeedConversion(parsecs);

            speedControl.ChangeValueTextbox(kms.ToString());
        }
    }
}
