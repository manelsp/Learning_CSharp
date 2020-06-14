namespace PV_POO
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
            this.button_Standard = new System.Windows.Forms.Button();
            this.button_Special = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Standard
            // 
            this.button_Standard.Location = new System.Drawing.Point(150, 84);
            this.button_Standard.Name = "button_Standard";
            this.button_Standard.Size = new System.Drawing.Size(131, 95);
            this.button_Standard.TabIndex = 0;
            this.button_Standard.Text = "Speed Conversor Standard";
            this.button_Standard.UseVisualStyleBackColor = true;
            this.button_Standard.Click += new System.EventHandler(this.button_Standard_Click);
            // 
            // button_Special
            // 
            this.button_Special.Location = new System.Drawing.Point(332, 84);
            this.button_Special.Name = "button_Special";
            this.button_Special.Size = new System.Drawing.Size(131, 95);
            this.button_Special.TabIndex = 1;
            this.button_Special.Text = "Speed Conversor Special";
            this.button_Special.UseVisualStyleBackColor = true;
            this.button_Special.Click += new System.EventHandler(this.button_Special_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 279);
            this.Controls.Add(this.button_Special);
            this.Controls.Add(this.button_Standard);
            this.Name = "frmMain";
            this.Text = "Spacial Speed Conversor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Standard;
        private System.Windows.Forms.Button button_Special;
    }
}

