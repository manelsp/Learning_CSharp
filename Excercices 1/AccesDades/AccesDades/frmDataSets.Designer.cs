namespace AccesDades
{
    partial class frmDataSets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Customer = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_NewCostumer = new System.Windows.Forms.Button();
            this.textBox_IdCustomer = new System.Windows.Forms.TextBox();
            this.textBox_IdCategory = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(45, 230);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(583, 238);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer:";
            // 
            // textBox_Customer
            // 
            this.textBox_Customer.Location = new System.Drawing.Point(129, 47);
            this.textBox_Customer.Name = "textBox_Customer";
            this.textBox_Customer.Size = new System.Drawing.Size(242, 26);
            this.textBox_Customer.TabIndex = 2;
            this.textBox_Customer.Tag = "[Nomclient]";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(129, 104);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(242, 26);
            this.textBox_mail.TabIndex = 4;
            this.textBox_mail.Tag = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mail:";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(129, 161);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(433, 28);
            this.comboBox_Category.TabIndex = 5;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category:";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(532, 496);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(125, 33);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_NewCostumer
            // 
            this.button_NewCostumer.Location = new System.Drawing.Point(395, 496);
            this.button_NewCostumer.Name = "button_NewCostumer";
            this.button_NewCostumer.Size = new System.Drawing.Size(125, 33);
            this.button_NewCostumer.TabIndex = 8;
            this.button_NewCostumer.Text = "New customer";
            this.button_NewCostumer.UseVisualStyleBackColor = true;
            this.button_NewCostumer.Click += new System.EventHandler(this.button_NewCostumer_Click);
            // 
            // textBox_IdCustomer
            // 
            this.textBox_IdCustomer.Location = new System.Drawing.Point(377, 47);
            this.textBox_IdCustomer.Name = "textBox_IdCustomer";
            this.textBox_IdCustomer.ReadOnly = true;
            this.textBox_IdCustomer.Size = new System.Drawing.Size(44, 26);
            this.textBox_IdCustomer.TabIndex = 9;
            this.textBox_IdCustomer.Tag = "IdCliente";
            // 
            // textBox_IdCategory
            // 
            this.textBox_IdCategory.Location = new System.Drawing.Point(568, 163);
            this.textBox_IdCategory.Name = "textBox_IdCategory";
            this.textBox_IdCategory.ReadOnly = true;
            this.textBox_IdCategory.Size = new System.Drawing.Size(44, 26);
            this.textBox_IdCategory.TabIndex = 10;
            this.textBox_IdCategory.Tag = "idCategoria";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // frmDataSets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 555);
            this.Controls.Add(this.textBox_IdCategory);
            this.Controls.Add(this.textBox_IdCustomer);
            this.Controls.Add(this.button_NewCostumer);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmDataSets";
            this.Text = "Datasets";
            this.Load += new System.EventHandler(this.frmDataSets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Customer;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_NewCostumer;
        private System.Windows.Forms.TextBox textBox_IdCustomer;
        private System.Windows.Forms.TextBox textBox_IdCategory;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}