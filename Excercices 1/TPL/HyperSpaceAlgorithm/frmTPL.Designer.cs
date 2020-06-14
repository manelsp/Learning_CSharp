namespace TPL
{
    partial class frmTPL
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
            this.cmdCheck = new System.Windows.Forms.Button();
            this.lstData3 = new System.Windows.Forms.ListBox();
            this.lstData1 = new System.Windows.Forms.ListBox();
            this.lstData2 = new System.Windows.Forms.ListBox();
            this.txtCheckTask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(62, 46);
            this.cmdCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(160, 35);
            this.cmdCheck.TabIndex = 0;
            this.cmdCheck.Text = "Check System";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // lstData3
            // 
            this.lstData3.FormattingEnabled = true;
            this.lstData3.HorizontalScrollbar = true;
            this.lstData3.ItemHeight = 20;
            this.lstData3.Location = new System.Drawing.Point(62, 108);
            this.lstData3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstData3.Name = "lstData3";
            this.lstData3.ScrollAlwaysVisible = true;
            this.lstData3.Size = new System.Drawing.Size(1435, 304);
            this.lstData3.TabIndex = 1;
            // 
            // lstData1
            // 
            this.lstData1.FormattingEnabled = true;
            this.lstData1.HorizontalScrollbar = true;
            this.lstData1.ItemHeight = 20;
            this.lstData1.Location = new System.Drawing.Point(62, 423);
            this.lstData1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstData1.Name = "lstData1";
            this.lstData1.ScrollAlwaysVisible = true;
            this.lstData1.Size = new System.Drawing.Size(1435, 304);
            this.lstData1.TabIndex = 2;
            // 
            // lstData2
            // 
            this.lstData2.FormattingEnabled = true;
            this.lstData2.HorizontalScrollbar = true;
            this.lstData2.ItemHeight = 20;
            this.lstData2.Location = new System.Drawing.Point(62, 738);
            this.lstData2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstData2.Name = "lstData2";
            this.lstData2.ScrollAlwaysVisible = true;
            this.lstData2.Size = new System.Drawing.Size(1435, 304);
            this.lstData2.TabIndex = 3;
            // 
            // txtCheckTask
            // 
            this.txtCheckTask.Location = new System.Drawing.Point(1522, 108);
            this.txtCheckTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckTask.Multiline = true;
            this.txtCheckTask.Name = "txtCheckTask";
            this.txtCheckTask.Size = new System.Drawing.Size(385, 192);
            this.txtCheckTask.TabIndex = 4;
            // 
            // frmTPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.txtCheckTask);
            this.Controls.Add(this.lstData2);
            this.Controls.Add(this.lstData1);
            this.Controls.Add(this.lstData3);
            this.Controls.Add(this.cmdCheck);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTPL";
            this.Text = "Processat de tasques en paral·lel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.ListBox lstData3;
        private System.Windows.Forms.ListBox lstData1;
        private System.Windows.Forms.ListBox lstData2;
        private System.Windows.Forms.TextBox txtCheckTask;
    }
}