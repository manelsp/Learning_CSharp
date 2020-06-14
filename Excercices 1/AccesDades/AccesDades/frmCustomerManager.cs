using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesDades
{
    public partial class frmCustomerManager : Form
    {
        public frmCustomerManager()
        {
            InitializeComponent();
        }

        private void entityFrameworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntityFramework form = new frmEntityFramework();

            form.MdiParent = this; 
            form.Show(); 
        }

        private void datasetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataSets form = new frmDataSets();

            form.MdiParent = this;
            form.Show();
        }

        private void quantAToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmQuantA form = new frmQuantA();

            form.MdiParent = this;
            form.Show();
        }
    }
}
