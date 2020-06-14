namespace Especies
{
    partial class Especies
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.button_Insertar = new System.Windows.Forms.Button();
            this.button_GuardarCambios = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.swTextbox2 = new CustomControls.SWTextbox();
            this.swTextbox1 = new CustomControls.SWTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Especies";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(19, 100);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 17);
            this.Label2.TabIndex = 86;
            this.Label2.Text = "Code especie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(19, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Desc especie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Buscar);
            this.groupBox1.Controls.Add(this.button_Insertar);
            this.groupBox1.Controls.Add(this.button_GuardarCambios);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 58);
            this.groupBox1.TabIndex = 90;
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
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(639, 172);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(71, 20);
            this.labelInfo.TabIndex = 91;
            this.labelInfo.Text = "*InfoText";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // swTextbox2
            // 
            this.swTextbox2.CampoBD = "DescSpecie";
            this.swTextbox2.CampoVacio = false;
            this.swTextbox2.ControlComboboxId = null;
            this.swTextbox2.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.swTextbox2.EsForanea = false;
            this.swTextbox2.Location = new System.Drawing.Point(123, 143);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(100, 20);
            this.swTextbox2.TabIndex = 89;
            // 
            // swTextbox1
            // 
            this.swTextbox1.CampoBD = "CodeSpecie";
            this.swTextbox1.CampoVacio = false;
            this.swTextbox1.ControlComboboxId = null;
            this.swTextbox1.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.swTextbox1.EsForanea = false;
            this.swTextbox1.Location = new System.Drawing.Point(123, 98);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.TabIndex = 87;
            // 
            // Especies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(970, 491);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Especies";
            this.Text = "Especies";
            this.Load += new System.EventHandler(this.Especies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private CustomControls.SWTextbox swTextbox1;
        private System.Windows.Forms.Label label3;
        private CustomControls.SWTextbox swTextbox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.Button button_Insertar;
        private System.Windows.Forms.Button button_GuardarCambios;
        private System.Windows.Forms.Label labelInfo;
    }
}