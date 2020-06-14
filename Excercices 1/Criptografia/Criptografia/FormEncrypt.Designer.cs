namespace Criptografia
{
    partial class FormEncrypt
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
            this.buttonObtenirClau = new System.Windows.Forms.Button();
            this.labelMissatgeOriginal = new System.Windows.Forms.Label();
            this.labelMissatgeEncriptat = new System.Windows.Forms.Label();
            this.textBoxMissatgeOriginal = new System.Windows.Forms.TextBox();
            this.textBoxMissatgeEncriptat = new System.Windows.Forms.TextBox();
            this.buttonEncriptar = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonMostrarClau = new System.Windows.Forms.Button();
            this.textBoxMostrarClau = new System.Windows.Forms.TextBox();
            this.labelAlerts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonObtenirClau
            // 
            this.buttonObtenirClau.Location = new System.Drawing.Point(12, 12);
            this.buttonObtenirClau.Name = "buttonObtenirClau";
            this.buttonObtenirClau.Size = new System.Drawing.Size(108, 32);
            this.buttonObtenirClau.TabIndex = 0;
            this.buttonObtenirClau.Text = "Obtenir clau";
            this.buttonObtenirClau.UseVisualStyleBackColor = true;
            this.buttonObtenirClau.Click += new System.EventHandler(this.buttonObtenirClau_Click);
            // 
            // labelMissatgeOriginal
            // 
            this.labelMissatgeOriginal.AutoSize = true;
            this.labelMissatgeOriginal.Location = new System.Drawing.Point(12, 61);
            this.labelMissatgeOriginal.Name = "labelMissatgeOriginal";
            this.labelMissatgeOriginal.Size = new System.Drawing.Size(127, 20);
            this.labelMissatgeOriginal.TabIndex = 1;
            this.labelMissatgeOriginal.Text = "Missatge original";
            // 
            // labelMissatgeEncriptat
            // 
            this.labelMissatgeEncriptat.AutoSize = true;
            this.labelMissatgeEncriptat.Location = new System.Drawing.Point(12, 107);
            this.labelMissatgeEncriptat.Name = "labelMissatgeEncriptat";
            this.labelMissatgeEncriptat.Size = new System.Drawing.Size(141, 20);
            this.labelMissatgeEncriptat.TabIndex = 2;
            this.labelMissatgeEncriptat.Text = "Missatge Encriptat";
            // 
            // textBoxMissatgeOriginal
            // 
            this.textBoxMissatgeOriginal.Location = new System.Drawing.Point(171, 61);
            this.textBoxMissatgeOriginal.Name = "textBoxMissatgeOriginal";
            this.textBoxMissatgeOriginal.Size = new System.Drawing.Size(273, 26);
            this.textBoxMissatgeOriginal.TabIndex = 3;
            // 
            // textBoxMissatgeEncriptat
            // 
            this.textBoxMissatgeEncriptat.Location = new System.Drawing.Point(171, 104);
            this.textBoxMissatgeEncriptat.Name = "textBoxMissatgeEncriptat";
            this.textBoxMissatgeEncriptat.ReadOnly = true;
            this.textBoxMissatgeEncriptat.Size = new System.Drawing.Size(273, 26);
            this.textBoxMissatgeEncriptat.TabIndex = 4;
            // 
            // buttonEncriptar
            // 
            this.buttonEncriptar.Location = new System.Drawing.Point(459, 58);
            this.buttonEncriptar.Name = "buttonEncriptar";
            this.buttonEncriptar.Size = new System.Drawing.Size(108, 32);
            this.buttonEncriptar.TabIndex = 5;
            this.buttonEncriptar.Text = "Encriptar";
            this.buttonEncriptar.UseVisualStyleBackColor = true;
            this.buttonEncriptar.Click += new System.EventHandler(this.buttonEncriptar_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(336, 142);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(108, 32);
            this.buttonEnviar.TabIndex = 6;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonMostrarClau
            // 
            this.buttonMostrarClau.Location = new System.Drawing.Point(12, 206);
            this.buttonMostrarClau.Name = "buttonMostrarClau";
            this.buttonMostrarClau.Size = new System.Drawing.Size(108, 32);
            this.buttonMostrarClau.TabIndex = 7;
            this.buttonMostrarClau.Text = "Mostrar clau";
            this.buttonMostrarClau.UseVisualStyleBackColor = true;
            this.buttonMostrarClau.Click += new System.EventHandler(this.buttonMostrarClau_Click);
            // 
            // textBoxMostrarClau
            // 
            this.textBoxMostrarClau.Location = new System.Drawing.Point(12, 244);
            this.textBoxMostrarClau.Multiline = true;
            this.textBoxMostrarClau.Name = "textBoxMostrarClau";
            this.textBoxMostrarClau.Size = new System.Drawing.Size(776, 134);
            this.textBoxMostrarClau.TabIndex = 8;
            // 
            // labelAlerts
            // 
            this.labelAlerts.AutoSize = true;
            this.labelAlerts.ForeColor = System.Drawing.Color.Red;
            this.labelAlerts.Location = new System.Drawing.Point(12, 388);
            this.labelAlerts.Name = "labelAlerts";
            this.labelAlerts.Size = new System.Drawing.Size(91, 20);
            this.labelAlerts.TabIndex = 9;
            this.labelAlerts.Text = "Label alerts";
            this.labelAlerts.Visible = false;
            // 
            // FormEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.labelAlerts);
            this.Controls.Add(this.textBoxMostrarClau);
            this.Controls.Add(this.buttonMostrarClau);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.buttonEncriptar);
            this.Controls.Add(this.textBoxMissatgeEncriptat);
            this.Controls.Add(this.textBoxMissatgeOriginal);
            this.Controls.Add(this.labelMissatgeEncriptat);
            this.Controls.Add(this.labelMissatgeOriginal);
            this.Controls.Add(this.buttonObtenirClau);
            this.Name = "FormEncrypt";
            this.Text = "Encriptar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonObtenirClau;
        private System.Windows.Forms.Label labelMissatgeOriginal;
        private System.Windows.Forms.Label labelMissatgeEncriptat;
        private System.Windows.Forms.TextBox textBoxMissatgeOriginal;
        private System.Windows.Forms.TextBox textBoxMissatgeEncriptat;
        private System.Windows.Forms.Button buttonEncriptar;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonMostrarClau;
        private System.Windows.Forms.TextBox textBoxMostrarClau;
        private System.Windows.Forms.Label labelAlerts;
    }
}