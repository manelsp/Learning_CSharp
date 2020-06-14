namespace UDPClient
{
    partial class frmUDPClient
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.textBox_Missatge = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.button_Data = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Missatge";
            // 
            // textBox_Server
            // 
            this.textBox_Server.Location = new System.Drawing.Point(107, 30);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(320, 26);
            this.textBox_Server.TabIndex = 3;
            // 
            // textBox_Missatge
            // 
            this.textBox_Missatge.Location = new System.Drawing.Point(107, 87);
            this.textBox_Missatge.Name = "textBox_Missatge";
            this.textBox_Missatge.Size = new System.Drawing.Size(504, 26);
            this.textBox_Missatge.TabIndex = 4;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(519, 30);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(92, 26);
            this.textBox_Port.TabIndex = 5;
            // 
            // button_Enviar
            // 
            this.button_Enviar.Location = new System.Drawing.Point(108, 138);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(115, 38);
            this.button_Enviar.TabIndex = 6;
            this.button_Enviar.Text = "Enviar";
            this.button_Enviar.UseVisualStyleBackColor = true;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // button_Data
            // 
            this.button_Data.Location = new System.Drawing.Point(238, 138);
            this.button_Data.Name = "button_Data";
            this.button_Data.Size = new System.Drawing.Size(148, 38);
            this.button_Data.TabIndex = 7;
            this.button_Data.Text = "Generate Data";
            this.button_Data.UseVisualStyleBackColor = true;
            this.button_Data.Click += new System.EventHandler(this.button_Data_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmUDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 188);
            this.Controls.Add(this.button_Data);
            this.Controls.Add(this.button_Enviar);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_Missatge);
            this.Controls.Add(this.textBox_Server);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUDPClient";
            this.Text = "UDP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.TextBox textBox_Missatge;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Button button_Enviar;
        private System.Windows.Forms.Button button_Data;
        private System.Windows.Forms.Timer timer;
    }
}

