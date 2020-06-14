namespace EDI
{
    partial class frmEdi
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
            this.textBox_fitxer = new System.Windows.Forms.TextBox();
            this.button_selecionarFitxer = new System.Windows.Forms.Button();
            this.button_stringFunctions = new System.Windows.Forms.Button();
            this.button_Linq = new System.Windows.Forms.Button();
            this.button_toXml = new System.Windows.Forms.Button();
            this.textBox_xml = new System.Windows.Forms.TextBox();
            this.textBoxNotifications = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fitxer:";
            // 
            // textBox_fitxer
            // 
            this.textBox_fitxer.Location = new System.Drawing.Point(60, 34);
            this.textBox_fitxer.Name = "textBox_fitxer";
            this.textBox_fitxer.ReadOnly = true;
            this.textBox_fitxer.Size = new System.Drawing.Size(457, 26);
            this.textBox_fitxer.TabIndex = 1;
            // 
            // button_selecionarFitxer
            // 
            this.button_selecionarFitxer.Location = new System.Drawing.Point(523, 32);
            this.button_selecionarFitxer.Name = "button_selecionarFitxer";
            this.button_selecionarFitxer.Size = new System.Drawing.Size(36, 34);
            this.button_selecionarFitxer.TabIndex = 2;
            this.button_selecionarFitxer.Text = "...";
            this.button_selecionarFitxer.UseVisualStyleBackColor = true;
            this.button_selecionarFitxer.Click += new System.EventHandler(this.button_selecionarFitxer_Click);
            // 
            // button_stringFunctions
            // 
            this.button_stringFunctions.Location = new System.Drawing.Point(46, 100);
            this.button_stringFunctions.Name = "button_stringFunctions";
            this.button_stringFunctions.Size = new System.Drawing.Size(144, 34);
            this.button_stringFunctions.TabIndex = 3;
            this.button_stringFunctions.Text = "String functions";
            this.button_stringFunctions.UseVisualStyleBackColor = true;
            this.button_stringFunctions.Click += new System.EventHandler(this.button_stringFunctions_Click);
            // 
            // button_Linq
            // 
            this.button_Linq.Location = new System.Drawing.Point(211, 100);
            this.button_Linq.Name = "button_Linq";
            this.button_Linq.Size = new System.Drawing.Size(75, 34);
            this.button_Linq.TabIndex = 4;
            this.button_Linq.Text = "LINQ";
            this.button_Linq.UseVisualStyleBackColor = true;
            this.button_Linq.Click += new System.EventHandler(this.button_Linq_Click);
            // 
            // button_toXml
            // 
            this.button_toXml.Location = new System.Drawing.Point(484, 100);
            this.button_toXml.Name = "button_toXml";
            this.button_toXml.Size = new System.Drawing.Size(103, 34);
            this.button_toXml.TabIndex = 5;
            this.button_toXml.Text = "To XML";
            this.button_toXml.UseVisualStyleBackColor = true;
            this.button_toXml.Click += new System.EventHandler(this.button_toXml_Click);
            // 
            // textBox_xml
            // 
            this.textBox_xml.Location = new System.Drawing.Point(484, 148);
            this.textBox_xml.Multiline = true;
            this.textBox_xml.Name = "textBox_xml";
            this.textBox_xml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_xml.Size = new System.Drawing.Size(295, 290);
            this.textBox_xml.TabIndex = 6;
            // 
            // textBoxNotifications
            // 
            this.textBoxNotifications.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNotifications.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNotifications.Location = new System.Drawing.Point(42, 148);
            this.textBoxNotifications.Multiline = true;
            this.textBoxNotifications.Name = "textBoxNotifications";
            this.textBoxNotifications.Size = new System.Drawing.Size(417, 159);
            this.textBoxNotifications.TabIndex = 7;
            // 
            // frmEdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNotifications);
            this.Controls.Add(this.textBox_xml);
            this.Controls.Add(this.button_toXml);
            this.Controls.Add(this.button_Linq);
            this.Controls.Add(this.button_stringFunctions);
            this.Controls.Add(this.button_selecionarFitxer);
            this.Controls.Add(this.textBox_fitxer);
            this.Controls.Add(this.label1);
            this.Name = "frmEdi";
            this.Text = "Processat de fitxers EDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fitxer;
        private System.Windows.Forms.Button button_selecionarFitxer;
        private System.Windows.Forms.Button button_stringFunctions;
        private System.Windows.Forms.Button button_Linq;
        private System.Windows.Forms.Button button_toXml;
        private System.Windows.Forms.TextBox textBox_xml;
        private System.Windows.Forms.TextBox textBoxNotifications;
    }
}

