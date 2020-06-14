namespace Criptografia
{
    partial class Desencriptar
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
            this.groupBoxGestioDeClaus = new System.Windows.Forms.GroupBox();
            this.buttonSelecionarRuta = new System.Windows.Forms.Button();
            this.buttonGenerarClaus = new System.Windows.Forms.Button();
            this.textBoxFitxerXMLpublickey = new System.Windows.Forms.TextBox();
            this.textBoxNomKeycontainer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMissatgeEncriptat = new System.Windows.Forms.TextBox();
            this.textBoxMissatgeOriginal = new System.Windows.Forms.TextBox();
            this.buttonDesencriptar = new System.Windows.Forms.Button();
            this.labelAlerts = new System.Windows.Forms.Label();
            this.groupBoxGestioDeClaus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGestioDeClaus
            // 
            this.groupBoxGestioDeClaus.Controls.Add(this.buttonSelecionarRuta);
            this.groupBoxGestioDeClaus.Controls.Add(this.buttonGenerarClaus);
            this.groupBoxGestioDeClaus.Controls.Add(this.textBoxFitxerXMLpublickey);
            this.groupBoxGestioDeClaus.Controls.Add(this.textBoxNomKeycontainer);
            this.groupBoxGestioDeClaus.Controls.Add(this.label2);
            this.groupBoxGestioDeClaus.Controls.Add(this.label1);
            this.groupBoxGestioDeClaus.Location = new System.Drawing.Point(33, 33);
            this.groupBoxGestioDeClaus.Name = "groupBoxGestioDeClaus";
            this.groupBoxGestioDeClaus.Size = new System.Drawing.Size(666, 184);
            this.groupBoxGestioDeClaus.TabIndex = 0;
            this.groupBoxGestioDeClaus.TabStop = false;
            this.groupBoxGestioDeClaus.Text = "Gestió de claus";
            // 
            // buttonSelecionarRuta
            // 
            this.buttonSelecionarRuta.Location = new System.Drawing.Point(552, 98);
            this.buttonSelecionarRuta.Name = "buttonSelecionarRuta";
            this.buttonSelecionarRuta.Size = new System.Drawing.Size(43, 30);
            this.buttonSelecionarRuta.TabIndex = 5;
            this.buttonSelecionarRuta.Text = "...";
            this.buttonSelecionarRuta.UseVisualStyleBackColor = true;
            this.buttonSelecionarRuta.Click += new System.EventHandler(this.buttonSelecionarRuta_Click);
            // 
            // buttonGenerarClaus
            // 
            this.buttonGenerarClaus.Location = new System.Drawing.Point(415, 134);
            this.buttonGenerarClaus.Name = "buttonGenerarClaus";
            this.buttonGenerarClaus.Size = new System.Drawing.Size(129, 44);
            this.buttonGenerarClaus.TabIndex = 4;
            this.buttonGenerarClaus.Text = "Generar claus";
            this.buttonGenerarClaus.UseVisualStyleBackColor = true;
            this.buttonGenerarClaus.Click += new System.EventHandler(this.buttonGenerarClaus_Click);
            // 
            // textBoxFitxerXMLpublickey
            // 
            this.textBoxFitxerXMLpublickey.Location = new System.Drawing.Point(193, 100);
            this.textBoxFitxerXMLpublickey.Name = "textBoxFitxerXMLpublickey";
            this.textBoxFitxerXMLpublickey.ReadOnly = true;
            this.textBoxFitxerXMLpublickey.Size = new System.Drawing.Size(351, 26);
            this.textBoxFitxerXMLpublickey.TabIndex = 3;
            // 
            // textBoxNomKeycontainer
            // 
            this.textBoxNomKeycontainer.Location = new System.Drawing.Point(193, 46);
            this.textBoxNomKeycontainer.Name = "textBoxNomKeycontainer";
            this.textBoxNomKeycontainer.Size = new System.Drawing.Size(156, 26);
            this.textBoxNomKeycontainer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fitxer XML public key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Keycontainer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Missatge encriptat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Missatge original";
            // 
            // textBoxMissatgeEncriptat
            // 
            this.textBoxMissatgeEncriptat.Location = new System.Drawing.Point(226, 270);
            this.textBoxMissatgeEncriptat.Name = "textBoxMissatgeEncriptat";
            this.textBoxMissatgeEncriptat.ReadOnly = true;
            this.textBoxMissatgeEncriptat.Size = new System.Drawing.Size(351, 26);
            this.textBoxMissatgeEncriptat.TabIndex = 6;
            // 
            // textBoxMissatgeOriginal
            // 
            this.textBoxMissatgeOriginal.Location = new System.Drawing.Point(226, 327);
            this.textBoxMissatgeOriginal.Name = "textBoxMissatgeOriginal";
            this.textBoxMissatgeOriginal.ReadOnly = true;
            this.textBoxMissatgeOriginal.Size = new System.Drawing.Size(351, 26);
            this.textBoxMissatgeOriginal.TabIndex = 8;
            // 
            // buttonDesencriptar
            // 
            this.buttonDesencriptar.Location = new System.Drawing.Point(595, 263);
            this.buttonDesencriptar.Name = "buttonDesencriptar";
            this.buttonDesencriptar.Size = new System.Drawing.Size(118, 40);
            this.buttonDesencriptar.TabIndex = 6;
            this.buttonDesencriptar.Text = "Desencriptar";
            this.buttonDesencriptar.UseVisualStyleBackColor = true;
            this.buttonDesencriptar.Click += new System.EventHandler(this.buttonDesencriptar_Click);
            // 
            // labelAlerts
            // 
            this.labelAlerts.AutoSize = true;
            this.labelAlerts.ForeColor = System.Drawing.Color.Red;
            this.labelAlerts.Location = new System.Drawing.Point(12, 385);
            this.labelAlerts.Name = "labelAlerts";
            this.labelAlerts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAlerts.Size = new System.Drawing.Size(91, 20);
            this.labelAlerts.TabIndex = 9;
            this.labelAlerts.Text = "Label alerts";
            this.labelAlerts.Visible = false;
            // 
            // Desencriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.labelAlerts);
            this.Controls.Add(this.buttonDesencriptar);
            this.Controls.Add(this.textBoxMissatgeOriginal);
            this.Controls.Add(this.textBoxMissatgeEncriptat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxGestioDeClaus);
            this.Name = "Desencriptar";
            this.Text = "Desencriptar";
            this.groupBoxGestioDeClaus.ResumeLayout(false);
            this.groupBoxGestioDeClaus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGestioDeClaus;
        private System.Windows.Forms.Button buttonSelecionarRuta;
        private System.Windows.Forms.Button buttonGenerarClaus;
        private System.Windows.Forms.TextBox textBoxFitxerXMLpublickey;
        private System.Windows.Forms.TextBox textBoxNomKeycontainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMissatgeEncriptat;
        private System.Windows.Forms.TextBox textBoxMissatgeOriginal;
        private System.Windows.Forms.Button buttonDesencriptar;
        private System.Windows.Forms.Label labelAlerts;
    }
}

