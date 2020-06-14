using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV_POO
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button_Standard_Click(object sender, EventArgs e)
        {
            SpeedConversorStandard.frmSpeed frmSpeed = new SpeedConversorStandard.frmSpeed();

            frmSpeed.Show();
        }

        private void button_Special_Click(object sender, EventArgs e)
        {
            SpeedConversorSpecial.frmSpeed frmSpeed = new SpeedConversorSpecial.frmSpeed();

            frmSpeed.Show();
        }
    }
}
