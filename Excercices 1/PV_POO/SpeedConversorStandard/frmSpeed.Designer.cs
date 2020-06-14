namespace SpeedConversorStandard
{
    partial class frmSpeed
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_parsecs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_convertSpeed = new System.Windows.Forms.Button();
            this.speedControl = new ControlsPOO.SpeedControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed (parsecs)";
            // 
            // textBox_parsecs
            // 
            this.textBox_parsecs.Location = new System.Drawing.Point(174, 44);
            this.textBox_parsecs.Name = "textBox_parsecs";
            this.textBox_parsecs.Size = new System.Drawing.Size(139, 26);
            this.textBox_parsecs.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_convertSpeed);
            this.groupBox1.Location = new System.Drawing.Point(455, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard Calculation";
            // 
            // button_convertSpeed
            // 
            this.button_convertSpeed.Location = new System.Drawing.Point(49, 37);
            this.button_convertSpeed.Name = "button_convertSpeed";
            this.button_convertSpeed.Size = new System.Drawing.Size(133, 32);
            this.button_convertSpeed.TabIndex = 0;
            this.button_convertSpeed.Text = "Convert Speed";
            this.button_convertSpeed.UseVisualStyleBackColor = true;
            this.button_convertSpeed.Click += new System.EventHandler(this.button_convertSpeed_Click);
            // 
            // speedControl
            // 
            this.speedControl.Location = new System.Drawing.Point(47, 75);
            this.speedControl.Name = "speedControl";
            this.speedControl.Size = new System.Drawing.Size(390, 102);
            this.speedControl.TabIndex = 6;
            // 
            // frmSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 191);
            this.Controls.Add(this.speedControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_parsecs);
            this.Controls.Add(this.label1);
            this.Name = "frmSpeed";
            this.Text = "Speed Conversor Standard";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_convertSpeed;
        public System.Windows.Forms.TextBox textBox_parsecs;
        public ControlsPOO.SpeedControl speedControl;
    }
}