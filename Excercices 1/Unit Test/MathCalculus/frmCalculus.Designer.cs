namespace MathCalculus
{
    partial class MathCalculus
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
            this.button_numbers = new System.Windows.Forms.Button();
            this.label_rndNumber1 = new System.Windows.Forms.Label();
            this.label_rndNumber2 = new System.Windows.Forms.Label();
            this.button_cmd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_cmdResultat = new System.Windows.Forms.Label();
            this.button_mcm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_mcmResultat = new System.Windows.Forms.Label();
            this.button_calculs = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_numbers
            // 
            this.button_numbers.Location = new System.Drawing.Point(39, 82);
            this.button_numbers.Name = "button_numbers";
            this.button_numbers.Size = new System.Drawing.Size(126, 32);
            this.button_numbers.TabIndex = 0;
            this.button_numbers.Text = "Numbers";
            this.button_numbers.UseVisualStyleBackColor = true;
            this.button_numbers.Click += new System.EventHandler(this.button_numbers_Click);
            // 
            // label_rndNumber1
            // 
            this.label_rndNumber1.AutoSize = true;
            this.label_rndNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rndNumber1.Location = new System.Drawing.Point(192, 88);
            this.label_rndNumber1.Name = "label_rndNumber1";
            this.label_rndNumber1.Size = new System.Drawing.Size(19, 20);
            this.label_rndNumber1.TabIndex = 1;
            this.label_rndNumber1.Text = "0";
            // 
            // label_rndNumber2
            // 
            this.label_rndNumber2.AutoSize = true;
            this.label_rndNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rndNumber2.Location = new System.Drawing.Point(228, 88);
            this.label_rndNumber2.Name = "label_rndNumber2";
            this.label_rndNumber2.Size = new System.Drawing.Size(19, 20);
            this.label_rndNumber2.TabIndex = 2;
            this.label_rndNumber2.Text = "0";
            // 
            // button_cmd
            // 
            this.button_cmd.Location = new System.Drawing.Point(39, 181);
            this.button_cmd.Name = "button_cmd";
            this.button_cmd.Size = new System.Drawing.Size(126, 32);
            this.button_cmd.TabIndex = 3;
            this.button_cmd.Text = "C.M.D";
            this.button_cmd.UseVisualStyleBackColor = true;
            this.button_cmd.Click += new System.EventHandler(this.button_cmd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result CMD: ";
            // 
            // label_cmdResultat
            // 
            this.label_cmdResultat.AutoSize = true;
            this.label_cmdResultat.Location = new System.Drawing.Point(301, 187);
            this.label_cmdResultat.Name = "label_cmdResultat";
            this.label_cmdResultat.Size = new System.Drawing.Size(18, 20);
            this.label_cmdResultat.TabIndex = 5;
            this.label_cmdResultat.Text = "0";
            // 
            // button_mcm
            // 
            this.button_mcm.Location = new System.Drawing.Point(39, 219);
            this.button_mcm.Name = "button_mcm";
            this.button_mcm.Size = new System.Drawing.Size(126, 32);
            this.button_mcm.TabIndex = 6;
            this.button_mcm.Text = "M.C.M";
            this.button_mcm.UseVisualStyleBackColor = true;
            this.button_mcm.Click += new System.EventHandler(this.button_mcm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Result MCM:";
            // 
            // label_mcmResultat
            // 
            this.label_mcmResultat.AutoSize = true;
            this.label_mcmResultat.Location = new System.Drawing.Point(301, 225);
            this.label_mcmResultat.Name = "label_mcmResultat";
            this.label_mcmResultat.Size = new System.Drawing.Size(18, 20);
            this.label_mcmResultat.TabIndex = 8;
            this.label_mcmResultat.Text = "0";
            // 
            // button_calculs
            // 
            this.button_calculs.Location = new System.Drawing.Point(39, 309);
            this.button_calculs.Name = "button_calculs";
            this.button_calculs.Size = new System.Drawing.Size(126, 32);
            this.button_calculs.TabIndex = 9;
            this.button_calculs.Text = "Set de calculs";
            this.button_calculs.UseVisualStyleBackColor = true;
            this.button_calculs.Click += new System.EventHandler(this.button_calculs_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Results:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(196, 344);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 204);
            this.listBox1.TabIndex = 11;
            // 
            // MathCalculus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 577);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_calculs);
            this.Controls.Add(this.label_mcmResultat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_mcm);
            this.Controls.Add(this.label_cmdResultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_cmd);
            this.Controls.Add(this.label_rndNumber2);
            this.Controls.Add(this.label_rndNumber1);
            this.Controls.Add(this.button_numbers);
            this.Name = "MathCalculus";
            this.Text = "Math Calculus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_numbers;
        private System.Windows.Forms.Label label_rndNumber1;
        private System.Windows.Forms.Label label_rndNumber2;
        private System.Windows.Forms.Button button_cmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_cmdResultat;
        private System.Windows.Forms.Button button_mcm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_mcmResultat;
        private System.Windows.Forms.Button button_calculs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
    }
}

