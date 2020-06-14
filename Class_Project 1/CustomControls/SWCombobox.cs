using System;
using System.Windows.Forms;
using AccesDades;
using System.Data; 

namespace CustomControls
{
    public partial class SWCombobox : ComboBox
    {
        private string _ControlTextboxId;
        private string _TableName;

        //Control Textbox Id textbox.value 
        public string ControlTextboxId
        {
            get { return _ControlTextboxId; }
            set { _ControlTextboxId = value; }
        }

        //Nom de la taula 
        public string TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }

        public SWCombobox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWCombobox
            // 
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SelectedValueChanged += new EventHandler(this.SWCombobox_SelectedValueChanged);
            this.ResumeLayout(false);

        }

        private void SWCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            Form myForm = this.FindForm();           

            if (myForm != null)
            {
                foreach (Control ctr in myForm.Controls)
                {
                    if (ctr.Name == _ControlTextboxId)
                    {
                            ctr.Text = this.SelectedValue.ToString();
                    }
                }
            }
        }

        public void ConnectDataBase()
        {
            string query = "SELECT * " +
                           "FROM " + TableName;
            
            ADO bd = new ADO();
            DataSet dts = bd.PortaDades(query);
            this.DataSource = dts.Tables[0];
        }

        public void CarregaCombo()
        {
            ConnectDataBase();
        }
    }
}
