using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace AccesDades
{
    public partial class frmEntityFramework : Form
    {
        public frmEntityFramework()
        {
            InitializeComponent();
        }

        BindingSource bs = new BindingSource();
        bool newrow;

        private void frmEntityFramework_Load(object sender, EventArgs e)
        {
            WriteDataGridView();

            Binding();
        }

        private void WriteDataGridView()
        {
            using (accesdadescovidEntities entities = new accesdadescovidEntities())
            {
                bs.DataSource = entities.Clients.ToList();

                comboBox_Category.DataSource = entities.Categories.ToList();
                comboBox_Category.DisplayMember = "DescCategoria";
                comboBox_Category.ValueMember = "idCategoria";
            }

            dataGridView1.DataSource = bs;

            dataGridView1.Columns["idCliente"].Visible = false;
            dataGridView1.Columns["Categories"].Visible = false;
        }

        private void Binding()
        {
            textBox_IdCustomer.DataBindings.Add("Text", bs, "idCliente");
            textBox_Customer.DataBindings.Add("Text", bs, "NomClient");
            textBox_mail.DataBindings.Add("Text", bs, "Mail");
            textBox_IdCategory.DataBindings.Add("Text", bs, "idCategoria");

            textBox_IdCustomer.TextChanged += new EventHandler(ValidateBinding);
            textBox_Customer.TextChanged += new EventHandler(ValidateBinding);
            textBox_mail.TextChanged += new EventHandler(ValidateBinding);
            textBox_IdCategory.TextChanged += new EventHandler(ValidateBinding);
        }

        private void button_NewCostumer_Click(object sender, EventArgs e)
        {
            if (!newrow)
            {
                foreach (Control control in this.Controls)
                {
                    control.DataBindings.Clear();

                    if (control is TextBox textbox)
                    {
                        textbox.Clear();
                    }
                }

                textBox_IdCategory.Text = "1";

                newrow = true;
            }
            else
            {
                using (accesdadescovidEntities entities = new accesdadescovidEntities())
                {
                    Clients client = new Clients
                    {
                        Nomclient = textBox_Customer.Text.Trim(),
                        Mail = textBox_mail.Text.Trim(),
                        idCategoria = int.Parse(textBox_IdCategory.Text.Trim())
                    };

                    entities.Clients.Add(client);
                    entities.SaveChanges();
                }

                WriteDataGridView();

                newrow = false;
            }
        }

        private void textBox_IdCategory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox_Category.SelectedValue = int.Parse(textBox_IdCategory.Text);
            }
            catch (Exception)
            {

            }
        }
        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_IdCategory.Text = comboBox_Category.SelectedValue.ToString();
        }

        private void ValidateBinding(object sender, EventArgs e)
        {
            try
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
            catch (Exception)
            {

            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            using (accesdadescovidEntities entities = new accesdadescovidEntities())
            {
                Clients client = entities.Clients.Find(int.Parse(textBox_IdCustomer.Text));
                client.Nomclient = textBox_Customer.Text.Trim();
                client.Mail = textBox_mail.Text.Trim();
                client.idCategoria = int.Parse(textBox_IdCategory.Text);

                entities.Clients.AddOrUpdate(client);
                entities.SaveChanges();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show("Estas segur de que vols elimnar?", "Confirmacio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    if (dr == DialogResult.Yes)
                    {
                        using (accesdadescovidEntities entities = new accesdadescovidEntities())
                        {
                            Clients client = entities.Clients.Find(int.Parse(textBox_IdCustomer.Text));

                            entities.Clients.Remove(client);

                            entities.SaveChanges();
                        }

                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    }
                }
            }
        }
    }
}
