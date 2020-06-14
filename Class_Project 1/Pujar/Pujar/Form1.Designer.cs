namespace Pujar
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
            this.Server = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Contrasenya = new System.Windows.Forms.Label();
            this.NomServer = new System.Windows.Forms.TextBox();
            this.NomUsuari = new System.Windows.Forms.TextBox();
            this.NomContrasenya = new System.Windows.Forms.TextBox();
            this.Pujar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Server.ForeColor = System.Drawing.Color.White;
            this.Server.Location = new System.Drawing.Point(235, 128);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(46, 17);
            this.Server.TabIndex = 0;
            this.Server.Text = "Server";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Nom.ForeColor = System.Drawing.Color.White;
            this.Nom.Location = new System.Drawing.Point(241, 162);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(40, 17);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom";
            // 
            // Contrasenya
            // 
            this.Contrasenya.AutoSize = true;
            this.Contrasenya.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Contrasenya.ForeColor = System.Drawing.Color.White;
            this.Contrasenya.Location = new System.Drawing.Point(191, 191);
            this.Contrasenya.Name = "Contrasenya";
            this.Contrasenya.Size = new System.Drawing.Size(90, 17);
            this.Contrasenya.TabIndex = 2;
            this.Contrasenya.Text = "Contrasenya";
            // 
            // NomServer
            // 
            this.NomServer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NomServer.Location = new System.Drawing.Point(287, 125);
            this.NomServer.Name = "NomServer";
            this.NomServer.Size = new System.Drawing.Size(280, 23);
            this.NomServer.TabIndex = 3;
            this.NomServer.Text = "ftp://172.17.6.0";
            // 
            // NomUsuari
            // 
            this.NomUsuari.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NomUsuari.Location = new System.Drawing.Point(287, 159);
            this.NomUsuari.Name = "NomUsuari";
            this.NomUsuari.Size = new System.Drawing.Size(280, 23);
            this.NomUsuari.TabIndex = 4;
            this.NomUsuari.Text = "g05";
            // 
            // NomContrasenya
            // 
            this.NomContrasenya.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NomContrasenya.Location = new System.Drawing.Point(287, 191);
            this.NomContrasenya.Name = "NomContrasenya";
            this.NomContrasenya.PasswordChar = '*';
            this.NomContrasenya.Size = new System.Drawing.Size(280, 23);
            this.NomContrasenya.TabIndex = 5;
            this.NomContrasenya.Text = "12345aA";
            // 
            // Pujar
            // 
            this.Pujar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pujar.Location = new System.Drawing.Point(639, 284);
            this.Pujar.Name = "Pujar";
            this.Pujar.Size = new System.Drawing.Size(110, 34);
            this.Pujar.TabIndex = 6;
            this.Pujar.Text = "Upload";
            this.Pujar.UseVisualStyleBackColor = true;
            this.Pujar.Click += new System.EventHandler(this.Pujar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(76, 244);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(673, 23);
            this.progressBar.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(412, 284);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(36, 22);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "0%";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Pujar);
            this.Controls.Add(this.NomContrasenya);
            this.Controls.Add(this.NomUsuari);
            this.Controls.Add(this.NomServer);
            this.Controls.Add(this.Contrasenya);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Contrasenya;
        private System.Windows.Forms.TextBox NomServer;
        private System.Windows.Forms.TextBox NomUsuari;
        private System.Windows.Forms.TextBox NomContrasenya;
        private System.Windows.Forms.Button Pujar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

