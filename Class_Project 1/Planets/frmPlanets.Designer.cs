namespace Planets
{
    partial class frmPlanets
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
            this.swTextbox2 = new CustomControls.SWTextbox();
            this.swTextbox3 = new CustomControls.SWTextbox();
            this.swTextbox5 = new CustomControls.SWTextbox();
            this.swTextbox6 = new CustomControls.SWTextbox();
            this.swTextbox7 = new CustomControls.SWTextbox();
            this.swTextbox8 = new CustomControls.SWTextbox();
            this.swTextbox9 = new CustomControls.SWTextbox();
            this.swCombobox1 = new CustomControls.SWCombobox();
            this.swCombobox2 = new CustomControls.SWCombobox();
            this.swCombobox3 = new CustomControls.SWCombobox();
            this.swTextbox1 = new CustomControls.SWTextbox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swTextbox2
            // 
            this.swTextbox2.CampoBD = "DescPlanet";
            this.swTextbox2.CampoVacio = false;
            this.swTextbox2.ControlComboboxId = null;
            this.swTextbox2.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.swTextbox2.EsForanea = false;
            this.swTextbox2.Location = new System.Drawing.Point(124, 147);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(131, 20);
            this.swTextbox2.TabIndex = 75;
            // 
            // swTextbox3
            // 
            this.swTextbox3.CampoBD = "long";
            this.swTextbox3.CampoVacio = false;
            this.swTextbox3.ControlComboboxId = null;
            this.swTextbox3.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Numero;
            this.swTextbox3.EsForanea = false;
            this.swTextbox3.Location = new System.Drawing.Point(343, 98);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(132, 20);
            this.swTextbox3.TabIndex = 76;
            // 
            // swTextbox5
            // 
            this.swTextbox5.CampoBD = "lat";
            this.swTextbox5.CampoVacio = false;
            this.swTextbox5.ControlComboboxId = null;
            this.swTextbox5.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Numero;
            this.swTextbox5.EsForanea = false;
            this.swTextbox5.Location = new System.Drawing.Point(343, 147);
            this.swTextbox5.Name = "swTextbox5";
            this.swTextbox5.Size = new System.Drawing.Size(132, 20);
            this.swTextbox5.TabIndex = 77;
            // 
            // swTextbox6
            // 
            this.swTextbox6.CampoBD = "idSector";
            this.swTextbox6.CampoVacio = false;
            this.swTextbox6.ControlComboboxId = "swCombobox1";
            this.swTextbox6.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Numero;
            this.swTextbox6.EsForanea = true;
            this.swTextbox6.Location = new System.Drawing.Point(910, 147);
            this.swTextbox6.Name = "swTextbox6";
            this.swTextbox6.Size = new System.Drawing.Size(21, 20);
            this.swTextbox6.TabIndex = 78;
            // 
            // swTextbox7
            // 
            this.swTextbox7.CampoBD = "idNatives";
            this.swTextbox7.CampoVacio = false;
            this.swTextbox7.ControlComboboxId = "swCombobox2";
            this.swTextbox7.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Numero;
            this.swTextbox7.EsForanea = true;
            this.swTextbox7.Location = new System.Drawing.Point(682, 148);
            this.swTextbox7.Name = "swTextbox7";
            this.swTextbox7.Size = new System.Drawing.Size(21, 20);
            this.swTextbox7.TabIndex = 79;
            // 
            // swTextbox8
            // 
            this.swTextbox8.CampoBD = "idFiliation";
            this.swTextbox8.CampoVacio = false;
            this.swTextbox8.ControlComboboxId = "swCombobox3";
            this.swTextbox8.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Numero;
            this.swTextbox8.EsForanea = true;
            this.swTextbox8.Location = new System.Drawing.Point(910, 99);
            this.swTextbox8.Name = "swTextbox8";
            this.swTextbox8.Size = new System.Drawing.Size(20, 20);
            this.swTextbox8.TabIndex = 80;
            // 
            // swTextbox9
            // 
            this.swTextbox9.CampoBD = "parsecs";
            this.swTextbox9.CampoVacio = false;
            this.swTextbox9.ControlComboboxId = null;
            this.swTextbox9.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Numero;
            this.swTextbox9.EsForanea = false;
            this.swTextbox9.Location = new System.Drawing.Point(556, 99);
            this.swTextbox9.Name = "swTextbox9";
            this.swTextbox9.Size = new System.Drawing.Size(147, 20);
            this.swTextbox9.TabIndex = 81;
            // 
            // swCombobox1
            // 
            this.swCombobox1.ControlTextboxId = "swTextbox6";
            this.swCombobox1.DisplayMember = "DescSector";
            this.swCombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.swCombobox1.FormattingEnabled = true;
            this.swCombobox1.Location = new System.Drawing.Point(783, 146);
            this.swCombobox1.Name = "swCombobox1";
            this.swCombobox1.Size = new System.Drawing.Size(121, 21);
            this.swCombobox1.TabIndex = 82;
            this.swCombobox1.TableName = "Sectors";
            this.swCombobox1.ValueMember = "idSector";
            // 
            // swCombobox2
            // 
            this.swCombobox2.ControlTextboxId = "swTextbox7";
            this.swCombobox2.DisplayMember = "CodeSpecie";
            this.swCombobox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.swCombobox2.FormattingEnabled = true;
            this.swCombobox2.Location = new System.Drawing.Point(555, 147);
            this.swCombobox2.Name = "swCombobox2";
            this.swCombobox2.Size = new System.Drawing.Size(121, 21);
            this.swCombobox2.TabIndex = 83;
            this.swCombobox2.TableName = "Species";
            this.swCombobox2.ValueMember = "idSpecie";
            // 
            // swCombobox3
            // 
            this.swCombobox3.ControlTextboxId = "swTextbox8";
            this.swCombobox3.DisplayMember = "CodeFiliation";
            this.swCombobox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.swCombobox3.FormattingEnabled = true;
            this.swCombobox3.Location = new System.Drawing.Point(783, 99);
            this.swCombobox3.Name = "swCombobox3";
            this.swCombobox3.Size = new System.Drawing.Size(121, 21);
            this.swCombobox3.TabIndex = 84;
            this.swCombobox3.TableName = "Filiations";
            this.swCombobox3.ValueMember = "idFiliation";
            // 
            // swTextbox1
            // 
            this.swTextbox1.CampoBD = "CodePlanet";
            this.swTextbox1.CampoVacio = false;
            this.swTextbox1.ControlComboboxId = null;
            this.swTextbox1.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.swTextbox1.EsForanea = false;
            this.swTextbox1.Location = new System.Drawing.Point(124, 99);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(131, 20);
            this.swTextbox1.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(27, 100);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 17);
            this.Label2.TabIndex = 85;
            this.Label2.Text = "Code planet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Desc planet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(297, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "Long";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(276, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 88;
            this.label5.Text = "Latitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(729, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "Sector";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(494, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 90;
            this.label7.Text = "Specie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(720, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 91;
            this.label8.Text = "Filiation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(494, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 92;
            this.label9.Text = "Parsecs";
            // 
            // frmPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BuscarPer = "DescPlanet";
            this.ClientSize = new System.Drawing.Size(970, 491);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.swCombobox3);
            this.Controls.Add(this.swCombobox2);
            this.Controls.Add(this.swCombobox1);
            this.Controls.Add(this.swTextbox9);
            this.Controls.Add(this.swTextbox8);
            this.Controls.Add(this.swTextbox7);
            this.Controls.Add(this.swTextbox6);
            this.Controls.Add(this.swTextbox5);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Name = "frmPlanets";
            this.Taula = "Planets";
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.swTextbox5, 0);
            this.Controls.SetChildIndex(this.swTextbox6, 0);
            this.Controls.SetChildIndex(this.swTextbox7, 0);
            this.Controls.SetChildIndex(this.swTextbox8, 0);
            this.Controls.SetChildIndex(this.swTextbox9, 0);
            this.Controls.SetChildIndex(this.swCombobox1, 0);
            this.Controls.SetChildIndex(this.swCombobox2, 0);
            this.Controls.SetChildIndex(this.swCombobox3, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.Label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.SWTextbox swTextbox2;
        private CustomControls.SWTextbox swTextbox3;
        private CustomControls.SWTextbox swTextbox5;
        private CustomControls.SWTextbox swTextbox6;
        private CustomControls.SWTextbox swTextbox7;
        private CustomControls.SWTextbox swTextbox8;
        private CustomControls.SWTextbox swTextbox9;
        private CustomControls.SWCombobox swCombobox1;
        private CustomControls.SWCombobox swCombobox2;
        private CustomControls.SWCombobox swCombobox3;
        private CustomControls.SWTextbox swTextbox1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
