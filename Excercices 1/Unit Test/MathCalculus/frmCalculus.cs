using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalculus
{
    public partial class MathCalculus : Form
    {
        Calculus calculus;

        public MathCalculus()
        {
            InitializeComponent();
        }

        private void button_numbers_Click(object sender, EventArgs e)
        {
            calculus = new Calculus();

            label_rndNumber1.Text = calculus.num1.ToString(); 
            label_rndNumber2.Text = calculus.num2.ToString(); 
        }

        private void button_cmd_Click(object sender, EventArgs e)
        {
            label_cmdResultat.Text = calculus.MCD().ToString();
        }

        private void button_mcm_Click(object sender, EventArgs e)
        {
            label_mcmResultat.Text = calculus.MCM().ToString();
        }

        private void button_calculs_Click(object sender, EventArgs e)
        {
            List<int> listRes = calculus.results();

            List<string> operationName = new List<string> {

                calculus.num1 + " + " + calculus.num2 + " = ",
                calculus.num1 + " - " + calculus.num2 + " = ",
                calculus.num2 + " - " + calculus.num1 + " = ",
                calculus.num1 + " x " + calculus.num2 + " = ",
                calculus.num1 + " / " + calculus.num2 + " = ",
                calculus.num2 + " / " + calculus.num1 + " = ",
            };
                
            listBox1.Items.Clear();

            for (int i = 0; i < listRes.Count; i++)
            {
                listBox1.Items.Add(operationName[i] + listRes[i]);
            }
        }
    }
}
