namespace Projecte1
{
    partial class Form_afterlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_afterlogin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasEnCascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasenHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasEnVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanasEnCascadaToolStripMenuItem,
            this.ventanasenHorizontalToolStripMenuItem,
            this.ventanasEnVerticalToolStripMenuItem,
            this.cerrarTodoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.archivoToolStripMenuItem.Text = "Ventanas";
            // 
            // ventanasEnCascadaToolStripMenuItem
            // 
            this.ventanasEnCascadaToolStripMenuItem.Name = "ventanasEnCascadaToolStripMenuItem";
            this.ventanasEnCascadaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ventanasEnCascadaToolStripMenuItem.Text = "Ventanas en cascada";
            this.ventanasEnCascadaToolStripMenuItem.Click += new System.EventHandler(this.ventanasEnCascadaToolStripMenuItem_Click);
            // 
            // ventanasenHorizontalToolStripMenuItem
            // 
            this.ventanasenHorizontalToolStripMenuItem.Name = "ventanasenHorizontalToolStripMenuItem";
            this.ventanasenHorizontalToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ventanasenHorizontalToolStripMenuItem.Text = "Ventanas horizontal";
            this.ventanasenHorizontalToolStripMenuItem.Click += new System.EventHandler(this.ventanasToolStripMenuItem_Click);
            // 
            // ventanasEnVerticalToolStripMenuItem
            // 
            this.ventanasEnVerticalToolStripMenuItem.Name = "ventanasEnVerticalToolStripMenuItem";
            this.ventanasEnVerticalToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ventanasEnVerticalToolStripMenuItem.Text = "Ventanas en vertical";
            this.ventanasEnVerticalToolStripMenuItem.Click += new System.EventHandler(this.ventanasEnVerticalToolStripMenuItem_Click);
            // 
            // cerrarTodoToolStripMenuItem
            // 
            this.cerrarTodoToolStripMenuItem.Name = "cerrarTodoToolStripMenuItem";
            this.cerrarTodoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cerrarTodoToolStripMenuItem.Text = "Cerrar todo";
            this.cerrarTodoToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodoToolStripMenuItem_Click_1);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Form_afterlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_afterlogin";
            this.Text = "Form_afterlogin";
            this.Load += new System.EventHandler(this.Form_afterlogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasEnCascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasenHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasEnVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodoToolStripMenuItem;
    }
}