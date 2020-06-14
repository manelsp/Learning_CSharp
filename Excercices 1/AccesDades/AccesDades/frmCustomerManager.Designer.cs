namespace AccesDades
{
    partial class frmCustomerManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datasetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entityFrameworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datasetsToolStripMenuItem,
            this.entityFrameworkToolStripMenuItem,
            this.quantAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datasetsToolStripMenuItem
            // 
            this.datasetsToolStripMenuItem.Name = "datasetsToolStripMenuItem";
            this.datasetsToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.datasetsToolStripMenuItem.Text = "Datasets";
            this.datasetsToolStripMenuItem.Click += new System.EventHandler(this.datasetsToolStripMenuItem_Click);
            // 
            // entityFrameworkToolStripMenuItem
            // 
            this.entityFrameworkToolStripMenuItem.Name = "entityFrameworkToolStripMenuItem";
            this.entityFrameworkToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.entityFrameworkToolStripMenuItem.Text = "Entity Framework";
            this.entityFrameworkToolStripMenuItem.Click += new System.EventHandler(this.entityFrameworkToolStripMenuItem_Click);
            // 
            // quantAToolStripMenuItem
            // 
            this.quantAToolStripMenuItem.Name = "quantAToolStripMenuItem";
            this.quantAToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.quantAToolStripMenuItem.Text = "Quant a...";
            this.quantAToolStripMenuItem.Click += new System.EventHandler(this.quantAToolStripMenuItem_Click);
            // 
            // frmCustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCustomerManager";
            this.Text = "Customer Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datasetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entityFrameworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantAToolStripMenuItem;
    }
}

