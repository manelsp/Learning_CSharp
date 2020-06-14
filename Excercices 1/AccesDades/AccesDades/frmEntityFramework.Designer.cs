namespace AccesDades
{
    partial class frmEntityFramework
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
            this.textBox_IdCategory = new System.Windows.Forms.TextBox();
            this.textBox_IdCustomer = new System.Windows.Forms.TextBox();
            this.button_NewCostumer = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_IdCategory
            // 
            this.textBox_IdCategory.Enabled = false;
            this.textBox_IdCategory.Location = new System.Drawing.Point(568, 163);
            this.textBox_IdCategory.Name = "textBox_IdCategory";
            this.textBox_IdCategory.Size = new System.Drawing.Size(44, 26);
            this.textBox_IdCategory.TabIndex = 21;
            this.textBox_IdCategory.TextChanged += new System.EventHandler(this.textBox_IdCategory_TextChanged);
            // 
            // textBox_IdCustomer
            // 
            this.textBox_IdCustomer.Enabled = false;
            this.textBox_IdCustomer.Location = new System.Drawing.Point(377, 47);
            this.textBox_IdCustomer.Name = "textBox_IdCustomer";
            this.textBox_IdCustomer.Size = new System.Drawing.Size(44, 26);
            this.textBox_IdCustomer.TabIndex = 20;
            // 
            // button_NewCostumer
            // 
            this.button_NewCostumer.Location = new System.Drawing.Point(395, 496);
            this.button_NewCostumer.Name = "button_NewCostumer";
            this.button_NewCostumer.Size = new System.Drawing.Size(125, 33);
            this.button_NewCostumer.TabIndex = 19;
            this.button_NewCostumer.Text = "New customer";
            this.button_NewCostumer.UseVisualStyleBackColor = true;
            this.button_NewCostumer.Click += new System.EventHandler(this.button_NewCostumer_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(532, 496);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(125, 33);
            this.button_Update.TabIndex = 18;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Category:";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(129, 161);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(433, 28);
            this.comboBox_Category.TabIndex = 16;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(129, 104);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(242, 26);
            this.textBox_mail.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mail:";
            // 
            // textBox_Customer
            // 
            this.textBox_Customer.Location = new System.Drawing.Point(129, 47);
            this.textBox_Customer.Name = "textBox_Customer";
            this.textBox_Customer.Size = new System.Drawing.Size(242, 26);
            this.textBox_Customer.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(583, 238);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // frmEntityFramework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 555);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEntityFramework";
            this.Text = "frmEntityFramework";
            this.Load += new System.EventHandler(this.frmEntityFramework_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_IdCategory;
        private System.Windows.Forms.TextBox textBox_IdCustomer;
        private System.Windows.Forms.Button button_NewCostumer;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}