namespace CustomControls
{
    partial class OpcionesMenu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Foto = new System.Windows.Forms.PictureBox();
            this.LabelDescripcio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(3, 3);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(43, 36);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Foto.TabIndex = 0;
            this.Foto.TabStop = false;
            this.Foto.Click += new System.EventHandler(this.Foto_Click);
            // 
            // LabelDescripcio
            // 
            this.LabelDescripcio.AutoSize = true;
            this.LabelDescripcio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripcio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.LabelDescripcio.Location = new System.Drawing.Point(51, 13);
            this.LabelDescripcio.Name = "LabelDescripcio";
            this.LabelDescripcio.Size = new System.Drawing.Size(74, 17);
            this.LabelDescripcio.TabIndex = 1;
            this.LabelDescripcio.Text = "NomTaula";
            this.LabelDescripcio.Click += new System.EventHandler(this.LabelDescripcio_Click);
            // 
            // OpcionesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LabelDescripcio);
            this.Controls.Add(this.Foto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OpcionesMenu";
            this.Size = new System.Drawing.Size(162, 42);
            this.Load += new System.EventHandler(this.OpcionesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Foto;
        public System.Windows.Forms.Label LabelDescripcio;
    }
}
