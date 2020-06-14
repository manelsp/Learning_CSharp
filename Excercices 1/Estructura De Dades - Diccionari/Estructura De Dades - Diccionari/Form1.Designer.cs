namespace Estructura_De_Dades___Diccionari
{
    partial class Dictionary
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
            this.buttonGenerarDiccionari = new System.Windows.Forms.Button();
            this.buttonMostrarDiccionari = new System.Windows.Forms.Button();
            this.buttonEsborrarVocals = new System.Windows.Forms.Button();
            this.labelSequenciaDeLletres = new System.Windows.Forms.Label();
            this.textBoxSequenciaDeLletres = new System.Windows.Forms.TextBox();
            this.textBoxEquivalentSequenciaDeLletres = new System.Windows.Forms.TextBox();
            this.textBoxInvertirCodificacio = new System.Windows.Forms.TextBox();
            this.buttonInvertirCodificacio = new System.Windows.Forms.Button();
            this.listBoxLetters = new System.Windows.Forms.ListBox();
            this.listBoxCode = new System.Windows.Forms.ListBox();
            this.labelAlerts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerarDiccionari
            // 
            this.buttonGenerarDiccionari.Location = new System.Drawing.Point(85, 32);
            this.buttonGenerarDiccionari.Name = "buttonGenerarDiccionari";
            this.buttonGenerarDiccionari.Size = new System.Drawing.Size(200, 35);
            this.buttonGenerarDiccionari.TabIndex = 0;
            this.buttonGenerarDiccionari.Text = "Generar Diccionari";
            this.buttonGenerarDiccionari.UseVisualStyleBackColor = true;
            this.buttonGenerarDiccionari.Click += new System.EventHandler(this.buttonGenerarDiccionari_Click);
            // 
            // buttonMostrarDiccionari
            // 
            this.buttonMostrarDiccionari.Location = new System.Drawing.Point(300, 32);
            this.buttonMostrarDiccionari.Name = "buttonMostrarDiccionari";
            this.buttonMostrarDiccionari.Size = new System.Drawing.Size(200, 35);
            this.buttonMostrarDiccionari.TabIndex = 1;
            this.buttonMostrarDiccionari.Text = "Mostrar Diccionari";
            this.buttonMostrarDiccionari.UseVisualStyleBackColor = true;
            this.buttonMostrarDiccionari.Click += new System.EventHandler(this.buttonMostrarDiccionari_Click);
            // 
            // buttonEsborrarVocals
            // 
            this.buttonEsborrarVocals.Location = new System.Drawing.Point(510, 32);
            this.buttonEsborrarVocals.Name = "buttonEsborrarVocals";
            this.buttonEsborrarVocals.Size = new System.Drawing.Size(200, 35);
            this.buttonEsborrarVocals.TabIndex = 2;
            this.buttonEsborrarVocals.Text = "Esborrar Vocals";
            this.buttonEsborrarVocals.UseVisualStyleBackColor = true;
            this.buttonEsborrarVocals.Click += new System.EventHandler(this.buttonEsborrarVocals_Click);
            // 
            // labelSequenciaDeLletres
            // 
            this.labelSequenciaDeLletres.AutoSize = true;
            this.labelSequenciaDeLletres.Location = new System.Drawing.Point(449, 112);
            this.labelSequenciaDeLletres.Name = "labelSequenciaDeLletres";
            this.labelSequenciaDeLletres.Size = new System.Drawing.Size(153, 20);
            this.labelSequenciaDeLletres.TabIndex = 5;
            this.labelSequenciaDeLletres.Text = "Seqüència de lletres";
            // 
            // textBoxSequenciaDeLletres
            // 
            this.textBoxSequenciaDeLletres.Location = new System.Drawing.Point(608, 109);
            this.textBoxSequenciaDeLletres.Name = "textBoxSequenciaDeLletres";
            this.textBoxSequenciaDeLletres.Size = new System.Drawing.Size(255, 26);
            this.textBoxSequenciaDeLletres.TabIndex = 6;
            this.textBoxSequenciaDeLletres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSequenciaDeLletres_KeyPress);
            // 
            // textBoxEquivalentSequenciaDeLletres
            // 
            this.textBoxEquivalentSequenciaDeLletres.Location = new System.Drawing.Point(608, 141);
            this.textBoxEquivalentSequenciaDeLletres.Multiline = true;
            this.textBoxEquivalentSequenciaDeLletres.Name = "textBoxEquivalentSequenciaDeLletres";
            this.textBoxEquivalentSequenciaDeLletres.ReadOnly = true;
            this.textBoxEquivalentSequenciaDeLletres.Size = new System.Drawing.Size(255, 134);
            this.textBoxEquivalentSequenciaDeLletres.TabIndex = 7;
            // 
            // textBoxInvertirCodificacio
            // 
            this.textBoxInvertirCodificacio.Location = new System.Drawing.Point(608, 281);
            this.textBoxInvertirCodificacio.Name = "textBoxInvertirCodificacio";
            this.textBoxInvertirCodificacio.ReadOnly = true;
            this.textBoxInvertirCodificacio.Size = new System.Drawing.Size(255, 26);
            this.textBoxInvertirCodificacio.TabIndex = 8;
            // 
            // buttonInvertirCodificacio
            // 
            this.buttonInvertirCodificacio.Location = new System.Drawing.Point(402, 277);
            this.buttonInvertirCodificacio.Name = "buttonInvertirCodificacio";
            this.buttonInvertirCodificacio.Size = new System.Drawing.Size(200, 35);
            this.buttonInvertirCodificacio.TabIndex = 9;
            this.buttonInvertirCodificacio.Text = "Invertir Codificació";
            this.buttonInvertirCodificacio.UseVisualStyleBackColor = true;
            this.buttonInvertirCodificacio.Click += new System.EventHandler(this.buttonInvertirCodificacio_Click);
            // 
            // listBoxLetters
            // 
            this.listBoxLetters.FormattingEnabled = true;
            this.listBoxLetters.ItemHeight = 20;
            this.listBoxLetters.Location = new System.Drawing.Point(37, 89);
            this.listBoxLetters.Name = "listBoxLetters";
            this.listBoxLetters.Size = new System.Drawing.Size(140, 524);
            this.listBoxLetters.TabIndex = 10;
            // 
            // listBoxCode
            // 
            this.listBoxCode.FormattingEnabled = true;
            this.listBoxCode.ItemHeight = 20;
            this.listBoxCode.Location = new System.Drawing.Point(201, 89);
            this.listBoxCode.Name = "listBoxCode";
            this.listBoxCode.Size = new System.Drawing.Size(140, 524);
            this.listBoxCode.TabIndex = 11;
            // 
            // labelAlerts
            // 
            this.labelAlerts.AutoSize = true;
            this.labelAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlerts.ForeColor = System.Drawing.Color.Red;
            this.labelAlerts.Location = new System.Drawing.Point(398, 328);
            this.labelAlerts.Name = "labelAlerts";
            this.labelAlerts.Size = new System.Drawing.Size(115, 22);
            this.labelAlerts.TabIndex = 12;
            this.labelAlerts.Text = "Label Alertas";
            this.labelAlerts.Visible = false;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 647);
            this.Controls.Add(this.labelAlerts);
            this.Controls.Add(this.listBoxCode);
            this.Controls.Add(this.listBoxLetters);
            this.Controls.Add(this.buttonInvertirCodificacio);
            this.Controls.Add(this.textBoxInvertirCodificacio);
            this.Controls.Add(this.textBoxEquivalentSequenciaDeLletres);
            this.Controls.Add(this.textBoxSequenciaDeLletres);
            this.Controls.Add(this.labelSequenciaDeLletres);
            this.Controls.Add(this.buttonEsborrarVocals);
            this.Controls.Add(this.buttonMostrarDiccionari);
            this.Controls.Add(this.buttonGenerarDiccionari);
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerarDiccionari;
        private System.Windows.Forms.Button buttonMostrarDiccionari;
        private System.Windows.Forms.Button buttonEsborrarVocals;
        private System.Windows.Forms.Label labelSequenciaDeLletres;
        private System.Windows.Forms.TextBox textBoxSequenciaDeLletres;
        private System.Windows.Forms.TextBox textBoxEquivalentSequenciaDeLletres;
        private System.Windows.Forms.TextBox textBoxInvertirCodificacio;
        private System.Windows.Forms.Button buttonInvertirCodificacio;
        private System.Windows.Forms.ListBox listBoxLetters;
        private System.Windows.Forms.ListBox listBoxCode;
        private System.Windows.Forms.Label labelAlerts;
    }
}

