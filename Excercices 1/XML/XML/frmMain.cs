using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button_xmlReader_Click(object sender, EventArgs e)
        {
            frmXmlReader frmXml = new frmXmlReader();

            frmXml.Show(); 
        }

        private void button_XmlDocument_Click(object sender, EventArgs e)
        {
            frmXmlDocument frmXml = new frmXmlDocument();

            frmXml.Show(); 
        }
    }
}
