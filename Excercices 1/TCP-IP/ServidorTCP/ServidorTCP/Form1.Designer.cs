namespace ServidorTCP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDesconnectar = new System.Windows.Forms.Button();
            this.buttonConnectar = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMissatges = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxMissatges);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDesconnectar);
            this.groupBox1.Controls.Add(this.buttonConnectar);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviament de dades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Missatges rebuts";
            // 
            // buttonDesconnectar
            // 
            this.buttonDesconnectar.Enabled = false;
            this.buttonDesconnectar.Location = new System.Drawing.Point(462, 45);
            this.buttonDesconnectar.Name = "buttonDesconnectar";
            this.buttonDesconnectar.Size = new System.Drawing.Size(161, 36);
            this.buttonDesconnectar.TabIndex = 3;
            this.buttonDesconnectar.Text = "Desconnectar";
            this.buttonDesconnectar.UseVisualStyleBackColor = true;
            this.buttonDesconnectar.Click += new System.EventHandler(this.buttonDesconnectar_Click);
            // 
            // buttonConnectar
            // 
            this.buttonConnectar.Location = new System.Drawing.Point(295, 45);
            this.buttonConnectar.Name = "buttonConnectar";
            this.buttonConnectar.Size = new System.Drawing.Size(161, 36);
            this.buttonConnectar.TabIndex = 2;
            this.buttonConnectar.Text = "Connectar";
            this.buttonConnectar.UseVisualStyleBackColor = true;
            this.buttonConnectar.Click += new System.EventHandler(this.buttonConnectar_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(94, 50);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(74, 26);
            this.textBoxPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // listBoxMissatges
            // 
            this.listBoxMissatges.FormattingEnabled = true;
            this.listBoxMissatges.ItemHeight = 20;
            this.listBoxMissatges.Location = new System.Drawing.Point(71, 165);
            this.listBoxMissatges.Name = "listBoxMissatges";
            this.listBoxMissatges.Size = new System.Drawing.Size(539, 184);
            this.listBoxMissatges.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 395);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ServidorTCP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConnectar;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDesconnectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMissatges;
    }
}

