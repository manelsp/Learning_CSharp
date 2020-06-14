namespace SpeedConversorSpecial
{
    partial class frmSpeed
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUnknowRegions = new System.Windows.Forms.Button();
            this.buttonCargoShuttle = new System.Windows.Forms.Button();
            this.buttonXwings = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUnknowRegions);
            this.groupBox2.Controls.Add(this.buttonCargoShuttle);
            this.groupBox2.Controls.Add(this.buttonXwings);
            this.groupBox2.Location = new System.Drawing.Point(704, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 125);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Special Calculation";
            // 
            // buttonUnknowRegions
            // 
            this.buttonUnknowRegions.Location = new System.Drawing.Point(78, 79);
            this.buttonUnknowRegions.Name = "buttonUnknowRegions";
            this.buttonUnknowRegions.Size = new System.Drawing.Size(134, 32);
            this.buttonUnknowRegions.TabIndex = 2;
            this.buttonUnknowRegions.Text = "Unknow regions";
            this.buttonUnknowRegions.UseVisualStyleBackColor = true;
            this.buttonUnknowRegions.Click += new System.EventHandler(this.buttonUnknowRegions_Click);
            // 
            // buttonCargoShuttle
            // 
            this.buttonCargoShuttle.Location = new System.Drawing.Point(146, 32);
            this.buttonCargoShuttle.Name = "buttonCargoShuttle";
            this.buttonCargoShuttle.Size = new System.Drawing.Size(125, 32);
            this.buttonCargoShuttle.TabIndex = 1;
            this.buttonCargoShuttle.Text = "Cargo Shuttle";
            this.buttonCargoShuttle.UseVisualStyleBackColor = true;
            this.buttonCargoShuttle.Click += new System.EventHandler(this.buttonCargoShuttle_Click);
            // 
            // buttonXwings
            // 
            this.buttonXwings.Location = new System.Drawing.Point(12, 32);
            this.buttonXwings.Name = "buttonXwings";
            this.buttonXwings.Size = new System.Drawing.Size(125, 32);
            this.buttonXwings.TabIndex = 0;
            this.buttonXwings.Text = "X-Wings";
            this.buttonXwings.UseVisualStyleBackColor = true;
            this.buttonXwings.Click += new System.EventHandler(this.buttonXwings_Click);
            // 
            // frmSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(999, 191);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSpeed";
            this.Controls.SetChildIndex(this.textBox_parsecs, 0);
            this.Controls.SetChildIndex(this.speedControl, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonUnknowRegions;
        private System.Windows.Forms.Button buttonCargoShuttle;
        private System.Windows.Forms.Button buttonXwings;
    }
}
