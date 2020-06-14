namespace ClientTCP
{
    partial class Form1
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
            this.groupBoxComprovacions = new System.Windows.Forms.GroupBox();
            this.listBoxNotificaciones = new System.Windows.Forms.ListBox();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelColorStatus = new System.Windows.Forms.Panel();
            this.buttonComprovarXarxa = new System.Windows.Forms.Button();
            this.groupBoxEnviamentDades = new System.Windows.Forms.GroupBox();
            this.buttonEnviarMissatge = new System.Windows.Forms.Button();
            this.textBoxMissatge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfiguracio = new System.Windows.Forms.Button();
            this.buttonDesconnectar = new System.Windows.Forms.Button();
            this.groupBoxComprovacions.SuspendLayout();
            this.groupBoxEnviamentDades.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComprovacions
            // 
            this.groupBoxComprovacions.Controls.Add(this.listBoxNotificaciones);
            this.groupBoxComprovacions.Controls.Add(this.labelConnectionStatus);
            this.groupBoxComprovacions.Controls.Add(this.label1);
            this.groupBoxComprovacions.Controls.Add(this.panelColorStatus);
            this.groupBoxComprovacions.Controls.Add(this.buttonComprovarXarxa);
            this.groupBoxComprovacions.Location = new System.Drawing.Point(12, 12);
            this.groupBoxComprovacions.Name = "groupBoxComprovacions";
            this.groupBoxComprovacions.Size = new System.Drawing.Size(561, 201);
            this.groupBoxComprovacions.TabIndex = 0;
            this.groupBoxComprovacions.TabStop = false;
            this.groupBoxComprovacions.Text = "Comprovacions";
            // 
            // listBoxNotificaciones
            // 
            this.listBoxNotificaciones.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNotificaciones.ForeColor = System.Drawing.Color.Lime;
            this.listBoxNotificaciones.FormattingEnabled = true;
            this.listBoxNotificaciones.ItemHeight = 20;
            this.listBoxNotificaciones.Location = new System.Drawing.Point(197, 32);
            this.listBoxNotificaciones.Name = "listBoxNotificaciones";
            this.listBoxNotificaciones.Size = new System.Drawing.Size(350, 144);
            this.listBoxNotificaciones.TabIndex = 4;
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(11, 158);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(171, 20);
            this.labelConnectionStatus.TabIndex = 3;
            this.labelConnectionStatus.Text = "Preparat per començar";
            this.labelConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "status";
            // 
            // panelColorStatus
            // 
            this.panelColorStatus.BackColor = System.Drawing.Color.Red;
            this.panelColorStatus.Location = new System.Drawing.Point(81, 106);
            this.panelColorStatus.Name = "panelColorStatus";
            this.panelColorStatus.Size = new System.Drawing.Size(37, 36);
            this.panelColorStatus.TabIndex = 1;
            // 
            // buttonComprovarXarxa
            // 
            this.buttonComprovarXarxa.Location = new System.Drawing.Point(24, 32);
            this.buttonComprovarXarxa.Name = "buttonComprovarXarxa";
            this.buttonComprovarXarxa.Size = new System.Drawing.Size(152, 34);
            this.buttonComprovarXarxa.TabIndex = 0;
            this.buttonComprovarXarxa.Text = "Comprovar xarxa";
            this.buttonComprovarXarxa.UseVisualStyleBackColor = true;
            this.buttonComprovarXarxa.Click += new System.EventHandler(this.buttonComprovarXarxa_Click);
            // 
            // groupBoxEnviamentDades
            // 
            this.groupBoxEnviamentDades.Controls.Add(this.buttonEnviarMissatge);
            this.groupBoxEnviamentDades.Controls.Add(this.textBoxMissatge);
            this.groupBoxEnviamentDades.Controls.Add(this.label5);
            this.groupBoxEnviamentDades.Controls.Add(this.textBoxPort);
            this.groupBoxEnviamentDades.Controls.Add(this.label4);
            this.groupBoxEnviamentDades.Controls.Add(this.textBoxIp);
            this.groupBoxEnviamentDades.Controls.Add(this.label3);
            this.groupBoxEnviamentDades.Location = new System.Drawing.Point(579, 12);
            this.groupBoxEnviamentDades.Name = "groupBoxEnviamentDades";
            this.groupBoxEnviamentDades.Size = new System.Drawing.Size(454, 201);
            this.groupBoxEnviamentDades.TabIndex = 1;
            this.groupBoxEnviamentDades.TabStop = false;
            this.groupBoxEnviamentDades.Text = "Enviament de dades";
            // 
            // buttonEnviarMissatge
            // 
            this.buttonEnviarMissatge.Enabled = false;
            this.buttonEnviarMissatge.Location = new System.Drawing.Point(304, 122);
            this.buttonEnviarMissatge.Name = "buttonEnviarMissatge";
            this.buttonEnviarMissatge.Size = new System.Drawing.Size(133, 34);
            this.buttonEnviarMissatge.TabIndex = 5;
            this.buttonEnviarMissatge.Text = "Enviar missatge";
            this.buttonEnviarMissatge.UseVisualStyleBackColor = true;
            this.buttonEnviarMissatge.Click += new System.EventHandler(this.buttonEnviarMissatge_Click);
            // 
            // textBoxMissatge
            // 
            this.textBoxMissatge.Location = new System.Drawing.Point(101, 77);
            this.textBoxMissatge.Name = "textBoxMissatge";
            this.textBoxMissatge.Size = new System.Drawing.Size(336, 26);
            this.textBoxMissatge.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Missatge";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(355, 29);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(82, 26);
            this.textBoxPort.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(101, 32);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(161, 26);
            this.textBoxIp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP";
            // 
            // buttonConfiguracio
            // 
            this.buttonConfiguracio.Location = new System.Drawing.Point(755, 219);
            this.buttonConfiguracio.Name = "buttonConfiguracio";
            this.buttonConfiguracio.Size = new System.Drawing.Size(133, 34);
            this.buttonConfiguracio.TabIndex = 11;
            this.buttonConfiguracio.Text = "Configuració";
            this.buttonConfiguracio.UseVisualStyleBackColor = true;
            this.buttonConfiguracio.Click += new System.EventHandler(this.buttonConfiguracio_Click);
            // 
            // buttonDesconnectar
            // 
            this.buttonDesconnectar.Enabled = false;
            this.buttonDesconnectar.Location = new System.Drawing.Point(894, 219);
            this.buttonDesconnectar.Name = "buttonDesconnectar";
            this.buttonDesconnectar.Size = new System.Drawing.Size(133, 34);
            this.buttonDesconnectar.TabIndex = 12;
            this.buttonDesconnectar.Text = "Desconnectar";
            this.buttonDesconnectar.UseVisualStyleBackColor = true;
            this.buttonDesconnectar.Click += new System.EventHandler(this.buttonDesconnectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 267);
            this.Controls.Add(this.buttonDesconnectar);
            this.Controls.Add(this.buttonConfiguracio);
            this.Controls.Add(this.groupBoxEnviamentDades);
            this.Controls.Add(this.groupBoxComprovacions);
            this.Name = "Form1";
            this.Text = "ClientTCP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxComprovacions.ResumeLayout(false);
            this.groupBoxComprovacions.PerformLayout();
            this.groupBoxEnviamentDades.ResumeLayout(false);
            this.groupBoxEnviamentDades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComprovacions;
        private System.Windows.Forms.GroupBox groupBoxEnviamentDades;
        private System.Windows.Forms.Button buttonComprovarXarxa;
        private System.Windows.Forms.ListBox listBoxNotificaciones;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelColorStatus;
        private System.Windows.Forms.Button buttonEnviarMissatge;
        private System.Windows.Forms.TextBox textBoxMissatge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfiguracio;
        private System.Windows.Forms.Button buttonDesconnectar;
    }
}

