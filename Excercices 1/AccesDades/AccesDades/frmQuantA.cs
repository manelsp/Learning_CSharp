using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesDades
{
    public partial class frmQuantA : Form
    {
        Assembly assembly = Assembly.GetExecutingAssembly(); 
        public frmQuantA()
        {
            InitializeComponent();
        }

        private void frmQuantA_Load(object sender, EventArgs e)
        {
            label1.Text = ((AssemblyTitleAttribute)assembly.GetCustomAttribute(typeof(AssemblyTitleAttribute))).Title;
            label2.Text = ((AssemblyDescriptionAttribute)assembly.GetCustomAttribute(typeof(AssemblyDescriptionAttribute))).Description;
            textBox1.Text = ((AssemblyCompanyAttribute)assembly.GetCustomAttribute(typeof(AssemblyCompanyAttribute))).Company;
            label3.Text = ((AssemblyProductAttribute)assembly.GetCustomAttribute(typeof(AssemblyProductAttribute))).Product;
            textBox2.Text = ((AssemblyCopyrightAttribute)assembly.GetCustomAttribute(typeof(AssemblyCopyrightAttribute))).Copyright;
        }
    }
}
