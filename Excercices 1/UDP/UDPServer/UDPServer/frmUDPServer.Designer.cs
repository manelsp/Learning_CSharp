namespace UDPServer
{
    partial class frmUDPServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.button_Connecta = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label_Estat = new System.Windows.Forms.Label();
            this.button_Tancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(65, 23);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(100, 26);
            this.textBox_Port.TabIndex = 1;
            // 
            // button_Connecta
            // 
            this.button_Connecta.Location = new System.Drawing.Point(181, 20);
            this.button_Connecta.Name = "button_Connecta";
            this.button_Connecta.Size = new System.Drawing.Size(115, 33);
            this.button_Connecta.TabIndex = 2;
            this.button_Connecta.Text = "Connecta";
            this.button_Connecta.UseVisualStyleBackColor = true;
            this.button_Connecta.Click += new System.EventHandler(this.button_Connecta_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(29, 120);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(378, 264);
            this.listBox.TabIndex = 3;
            // 
            // label_Estat
            // 
            this.label_Estat.AutoSize = true;
            this.label_Estat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Estat.ForeColor = System.Drawing.Color.Red;
            this.label_Estat.Location = new System.Drawing.Point(35, 92);
            this.label_Estat.Name = "label_Estat";
            this.label_Estat.Size = new System.Drawing.Size(121, 20);
            this.label_Estat.TabIndex = 4;
            this.label_Estat.Text = "Desconnectat";
            // 
            // button_Tancar
            // 
            this.button_Tancar.Location = new System.Drawing.Point(292, 402);
            this.button_Tancar.Name = "button_Tancar";
            this.button_Tancar.Size = new System.Drawing.Size(115, 36);
            this.button_Tancar.TabIndex = 5;
            this.button_Tancar.Text = "Tancar";
            this.button_Tancar.UseVisualStyleBackColor = true;
            this.button_Tancar.Click += new System.EventHandler(this.button_Tancar_Click);
            // 
            // frmUDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.button_Tancar);
            this.Controls.Add(this.label_Estat);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button_Connecta);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label1);
            this.Name = "frmUDPServer";
            this.Text = "UDP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Button button_Connecta;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label_Estat;
        private System.Windows.Forms.Button button_Tancar;
    }
}

