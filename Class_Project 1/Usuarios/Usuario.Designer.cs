namespace Usuarios
{
    partial class Usuario
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
            this.swTextbox1 = new CustomControls.SWTextbox();
            this.swTextbox2 = new CustomControls.SWTextbox();
            this.swTextbox3 = new CustomControls.SWTextbox();
            this.SWPassword = new CustomControls.SWTextbox();
            this.swCombobox1 = new CustomControls.SWCombobox();
            this.swCombobox2 = new CustomControls.SWCombobox();
            this.swTextbox4 = new CustomControls.SWTextbox();
            this.swTextbox6 = new CustomControls.SWTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Imprimir = new System.Windows.Forms.Button();
            this.SWIDUser = new CustomControls.SWTextbox();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.CampoBD = "CodeUser";
            this.swTextbox1.CampoVacio = false;
            this.swTextbox1.ControlComboboxId = null;
            this.swTextbox1.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.swTextbox1.EsForanea = false;
            this.swTextbox1.Location = new System.Drawing.Point(249, 85);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.TabIndex = 74;
            // 
            // swTextbox2
            // 
            this.swTextbox2.CampoBD = "UserName";
            this.swTextbox2.CampoVacio = false;
            this.swTextbox2.ControlComboboxId = null;
            this.swTextbox2.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.swTextbox2.EsForanea = false;
            this.swTextbox2.Location = new System.Drawing.Point(249, 124);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(100, 20);
            this.swTextbox2.TabIndex = 75;
            // 
            // swTextbox3
            // 
            this.swTextbox3.CampoBD = "Login";
            this.swTextbox3.CampoVacio = false;
            this.swTextbox3.ControlComboboxId = null;
            this.swTextbox3.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.swTextbox3.EsForanea = false;
            this.swTextbox3.Location = new System.Drawing.Point(451, 85);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(100, 20);
            this.swTextbox3.TabIndex = 76;
            // 
            // SWPassword
            // 
            this.SWPassword.CampoBD = "Password";
            this.SWPassword.CampoVacio = false;
            this.SWPassword.ControlComboboxId = null;
            this.SWPassword.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Todo;
            this.SWPassword.EsForanea = false;
            this.SWPassword.Location = new System.Drawing.Point(451, 125);
            this.SWPassword.Name = "SWPassword";
            this.SWPassword.Size = new System.Drawing.Size(100, 20);
            this.SWPassword.TabIndex = 78;
            // 
            // swCombobox1
            // 
            this.swCombobox1.ControlTextboxId = "swTextbox6";
            this.swCombobox1.DisplayMember = "DescRank";
            this.swCombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.swCombobox1.FormattingEnabled = true;
            this.swCombobox1.Location = new System.Drawing.Point(674, 84);
            this.swCombobox1.Name = "swCombobox1";
            this.swCombobox1.Size = new System.Drawing.Size(121, 21);
            this.swCombobox1.TabIndex = 79;
            this.swCombobox1.TableName = "UserRanks";
            this.swCombobox1.ValueMember = "idUserRank";
            // 
            // swCombobox2
            // 
            this.swCombobox2.ControlTextboxId = "swTextbox4";
            this.swCombobox2.DisplayMember = "DescCategory";
            this.swCombobox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.swCombobox2.FormattingEnabled = true;
            this.swCombobox2.Location = new System.Drawing.Point(674, 122);
            this.swCombobox2.Name = "swCombobox2";
            this.swCombobox2.Size = new System.Drawing.Size(121, 21);
            this.swCombobox2.TabIndex = 80;
            this.swCombobox2.TableName = "UserCategories";
            this.swCombobox2.ValueMember = "idUserCategory";
            // 
            // swTextbox4
            // 
            this.swTextbox4.CampoBD = "idUserCategory";
            this.swTextbox4.CampoVacio = false;
            this.swTextbox4.ControlComboboxId = "swCombobox2";
            this.swTextbox4.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Numero;
            this.swTextbox4.EsForanea = true;
            this.swTextbox4.Location = new System.Drawing.Point(801, 123);
            this.swTextbox4.Name = "swTextbox4";
            this.swTextbox4.Size = new System.Drawing.Size(27, 20);
            this.swTextbox4.TabIndex = 81;
            // 
            // swTextbox6
            // 
            this.swTextbox6.CampoBD = "idUserRank";
            this.swTextbox6.CampoVacio = false;
            this.swTextbox6.ControlComboboxId = "swCombobox1";
            this.swTextbox6.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Numero;
            this.swTextbox6.EsForanea = true;
            this.swTextbox6.Location = new System.Drawing.Point(801, 83);
            this.swTextbox6.Name = "swTextbox6";
            this.swTextbox6.Size = new System.Drawing.Size(27, 20);
            this.swTextbox6.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(170, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "CodeUser";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(170, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 85;
            this.label4.Text = "UserName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(376, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(402, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 87;
            this.label6.Text = "Login";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(562, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 88;
            this.label7.Text = "idUserCategory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(591, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 89;
            this.label8.Text = "idUserRank";
            // 
            // Imprimir
            // 
            this.Imprimir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Imprimir.Location = new System.Drawing.Point(844, 159);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(104, 33);
            this.Imprimir.TabIndex = 90;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // SWIDUser
            // 
            this.SWIDUser.CampoBD = "IdUser";
            this.SWIDUser.CampoVacio = false;
            this.SWIDUser.ControlComboboxId = null;
            this.SWIDUser.DatoCorrecto = CustomControls.SWTextbox.TipoDeDato.Texto;
            this.SWIDUser.EsForanea = false;
            this.SWIDUser.Location = new System.Drawing.Point(249, 159);
            this.SWIDUser.Name = "SWIDUser";
            this.SWIDUser.Size = new System.Drawing.Size(0, 20);
            this.SWIDUser.TabIndex = 91;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(970, 491);
            this.Controls.Add(this.SWIDUser);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.swTextbox6);
            this.Controls.Add(this.swTextbox4);
            this.Controls.Add(this.swCombobox2);
            this.Controls.Add(this.swCombobox1);
            this.Controls.Add(this.SWPassword);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "Usuario";
            this.Taula = "Users";
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.SWPassword, 0);
            this.Controls.SetChildIndex(this.swCombobox1, 0);
            this.Controls.SetChildIndex(this.swCombobox2, 0);
            this.Controls.SetChildIndex(this.swTextbox4, 0);
            this.Controls.SetChildIndex(this.swTextbox6, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.Imprimir, 0);
            this.Controls.SetChildIndex(this.SWIDUser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextbox swTextbox1;
        private CustomControls.SWTextbox swTextbox2;
        private CustomControls.SWTextbox swTextbox3;
        private CustomControls.SWTextbox SWPassword;
        private CustomControls.SWCombobox swCombobox1;
        private CustomControls.SWCombobox swCombobox2;
        private CustomControls.SWTextbox swTextbox4;
        private CustomControls.SWTextbox swTextbox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Imprimir;
        private CustomControls.SWTextbox SWIDUser;
    }
}
