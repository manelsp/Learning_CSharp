namespace ProvaDades
{
    partial class General
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
            this.Label_Taula = new System.Windows.Forms.Label();
            this.button_Insertar = new System.Windows.Forms.Button();
            this.button_GuardarCambios = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Taula
            // 
            this.Label_Taula.AutoSize = true;
            this.Label_Taula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_Taula.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Taula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Taula.Location = new System.Drawing.Point(6, 9);
            this.Label_Taula.Name = "Label_Taula";
            this.Label_Taula.Size = new System.Drawing.Size(216, 58);
            this.Label_Taula.TabIndex = 73;
            this.Label_Taula.Text = "General";
            // 
            // button_Insertar
            // 
            this.button_Insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Insertar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button_Insertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_Insertar.Location = new System.Drawing.Point(642, 17);
            this.button_Insertar.Name = "button_Insertar";
            this.button_Insertar.Size = new System.Drawing.Size(145, 33);
            this.button_Insertar.TabIndex = 60;
            this.button_Insertar.Text = "Nuevo";
            this.button_Insertar.UseVisualStyleBackColor = true;
            this.button_Insertar.Click += new System.EventHandler(this.button_Insertar_Click);
            // 
            // button_GuardarCambios
            // 
            this.button_GuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_GuardarCambios.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button_GuardarCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_GuardarCambios.Location = new System.Drawing.Point(793, 17);
            this.button_GuardarCambios.Name = "button_GuardarCambios";
            this.button_GuardarCambios.Size = new System.Drawing.Size(147, 33);
            this.button_GuardarCambios.TabIndex = 58;
            this.button_GuardarCambios.Text = "Guardar cambios";
            this.button_GuardarCambios.UseVisualStyleBackColor = true;
            this.button_GuardarCambios.Click += new System.EventHandler(this.button_GuardarCambios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Buscar);
            this.groupBox1.Controls.Add(this.button_Insertar);
            this.groupBox1.Controls.Add(this.button_GuardarCambios);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(8, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 58);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(8, 22);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(148, 23);
            this.textBox_Buscar.TabIndex = 11;
            this.textBox_Buscar.TextChanged += new System.EventHandler(this.textBox_Buscar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(946, 221);
            this.dataGridView1.TabIndex = 63;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(970, 491);
            this.Controls.Add(this.Label_Taula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "General";
            this.Text = "7";
            this.Load += new System.EventHandler(this.General_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Taula;
        private System.Windows.Forms.Button button_Insertar;
        private System.Windows.Forms.Button button_GuardarCambios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Buscar;
        protected System.Windows.Forms.DataGridView dataGridView1;
    }
}