namespace XML
{
    partial class frmMain
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
            this.button_xmlReader = new System.Windows.Forms.Button();
            this.button_XmlDocument = new System.Windows.Forms.Button();
            this.button_Linq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_xmlReader
            // 
            this.button_xmlReader.Location = new System.Drawing.Point(47, 83);
            this.button_xmlReader.Name = "button_xmlReader";
            this.button_xmlReader.Size = new System.Drawing.Size(162, 83);
            this.button_xmlReader.TabIndex = 0;
            this.button_xmlReader.Text = "XML Reader";
            this.button_xmlReader.UseVisualStyleBackColor = true;
            this.button_xmlReader.Click += new System.EventHandler(this.button_xmlReader_Click);
            // 
            // button_XmlDocument
            // 
            this.button_XmlDocument.Location = new System.Drawing.Point(248, 83);
            this.button_XmlDocument.Name = "button_XmlDocument";
            this.button_XmlDocument.Size = new System.Drawing.Size(162, 83);
            this.button_XmlDocument.TabIndex = 1;
            this.button_XmlDocument.Text = "XML Document";
            this.button_XmlDocument.UseVisualStyleBackColor = true;
            this.button_XmlDocument.Click += new System.EventHandler(this.button_XmlDocument_Click);
            // 
            // button_Linq
            // 
            this.button_Linq.Location = new System.Drawing.Point(446, 83);
            this.button_Linq.Name = "button_Linq";
            this.button_Linq.Size = new System.Drawing.Size(162, 83);
            this.button_Linq.TabIndex = 2;
            this.button_Linq.Text = "LINQ to Xml";
            this.button_Linq.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 266);
            this.Controls.Add(this.button_Linq);
            this.Controls.Add(this.button_XmlDocument);
            this.Controls.Add(this.button_xmlReader);
            this.Name = "frmMain";
            this.Text = "Test per a XML";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_xmlReader;
        private System.Windows.Forms.Button button_XmlDocument;
        private System.Windows.Forms.Button button_Linq;
    }
}

