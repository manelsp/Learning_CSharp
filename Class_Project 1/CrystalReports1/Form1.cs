using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace CrystalReports1
{
    public partial class Form1 : Form
    {
        private string id;
        public Form1(string _id)
        {
            id = _id;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CrystalReport1 crpt = new CrystalReport1();

            crpt.SetDatabaseLogon("EstrellaDam", "123456aA");
            crpt.RecordSelectionFormula = "{Users.idUser} = " + id;
            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
