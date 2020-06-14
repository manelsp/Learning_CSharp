using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace AccesDades
{
    public partial class frmDataSets : Form
    {
        private string connectionString = "Server=den1.mssql8.gear.host; Database=accesdadescovid; User Id=accesdadescovid; Password=123456aA!";

        private SqlConnection connectionSql;

        private DataSet dataSet;

        private bool newRow = false;
        
        public frmDataSets()
        {
            InitializeComponent();
        }

        private void frmDataSets_Load(object sender, EventArgs e)
        {
            ConnectDatabase();

            WritteDataGridView();

            LoadCategories();

            DataBinding();
        }

        private void ConnectDatabase()
        {
            connectionSql = new SqlConnection(connectionString);

            try
            {
                connectionSql.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void WritteDataGridView()
        {
            string query = "SELECT * " +
                           "FROM Clients";

            dataSet = GetDataSet(query);

            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void LoadCategories()
        {
            string query = "SELECT * " +
                            "FROM CATEGORIES";

            DataSet dataSet = GetDataSet(query);
            comboBox_Category.DataSource = dataSet.Tables[0];
            comboBox_Category.ValueMember = "IdCategoria";
            comboBox_Category.DisplayMember = "DescCategoria";
        }

        private void DataBinding()
        {
            foreach (Control textbox in this.Controls)
            {
                if (textbox.GetType() == typeof(TextBox))
                {
                    textbox.DataBindings.Clear(); 
                }
            }

            //Textboxs
            textBox_Customer.DataBindings.Add("Text", dataSet.Tables[0], "NomClient");
            textBox_mail.DataBindings.Add("Text", dataSet.Tables[0], "Mail");
            textBox_IdCategory.DataBindings.Add("Text", dataSet.Tables[0], "idCategoria");
            textBox_IdCustomer.DataBindings.Add("Text", dataSet.Tables[0], "idCliente");

            textBox_Customer.TextChanged += new EventHandler(validateBinding);
            textBox_mail.TextChanged += new EventHandler(validateBinding);
            textBox_IdCategory.TextChanged += new EventHandler(validateBinding);
        }

        private DataSet GetDataSet(string query)
        {
            DataSet dts = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            adapter.Fill(dts);

            return dts;
        }

        private void button_NewCostumer_Click(object sender, EventArgs e)
        {
            DataRow row;

            string query = "SELECT * " +
                            "FROM Clients";

            if (!newRow)
            {
                foreach (Control textbox in this.Controls)
                {
                    if (textbox.GetType() == typeof(TextBox) && !(textbox.Name == "txt_id_category"))
                    {
                        textbox.DataBindings.Clear();
                        textbox.Text = "";
                    }
                }

                newRow = true;
            }
            else
            {
                dataSet = GetDataSet(query);

                row = dataSet.Tables[0].NewRow();

                row["Nomclient"] = textBox_Customer.Text;
                row["Mail"] = textBox_mail.Text;
                row["idCategoria"] = comboBox_Category.SelectedIndex;

                textBox_IdCategory.Text = comboBox_Category.SelectedValue.ToString();

                dataSet.Tables[0].Rows.Add(row);

                UpdateDatabase();

                WritteDataGridView();

                newRow = false;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {    
            DataBinding();

            UpdateDatabase();

            WritteDataGridView();
        }

        private void notification(string message)
        {
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipTitle = "CRUD Operation";
            notifyIcon.BalloonTipText = message;
            notifyIcon.ShowBalloonTip(1000);
        }

        private void UpdateDatabase()
        {
            string query = "SELECT * " +
                            "FROM CLIENTS";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

            adapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();
            adapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();

            if (dataSet.HasChanges())
            {
                try
                {
                    adapter.Update(dataSet.Tables[0]);

                }
                catch (Exception)
                {

                }
            }
            else
            {
                notification("No hi ha canvis");
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show("Estas segur de que vols eliminar?", "Confirmacio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (dataGridView.SelectedRows.Count == 1)
                    {
                        dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);

                        UpdateDatabase();
                    }
                }
            }
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_IdCategory.Text = comboBox_Category.SelectedValue.ToString();
        }

        private void validateBinding(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                try
                {
                    ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}

