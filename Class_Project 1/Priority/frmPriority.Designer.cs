namespace Priority
{
    partial class frmPriority
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
            this.p1 = new CustomControls.SWTextbox();
            this.p2 = new CustomControls.SWTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.CampoBD = "CodePriority";
            this.p1.CampoVacio = false;
            this.p1.ControlComboboxId = null;
            this.p1.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.p1.EsForanea = false;
            this.p1.Location = new System.Drawing.Point(114, 97);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(138, 20);
            this.p1.TabIndex = 74;
            // 
            // p2
            // 
            this.p2.CampoBD = "DescPriority";
            this.p2.CampoVacio = false;
            this.p2.ControlComboboxId = null;
            this.p2.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.p2.EsForanea = false;
            this.p2.Location = new System.Drawing.Point(114, 147);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(138, 20);
            this.p2.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Code Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Code Priority";
            // 
            // frmPriorities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BuscarPer = "DescPriority";
            this.ClientSize = new System.Drawing.Size(970, 491);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Name = "frmPriorities";
            this.Taula = "Priority";
            this.Controls.SetChildIndex(this.p1, 0);
            this.Controls.SetChildIndex(this.p2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox p1;
        private CustomControls.SWTextbox p2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
