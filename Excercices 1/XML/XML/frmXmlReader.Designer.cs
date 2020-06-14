namespace XML
{
    partial class frmXmlReader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.textBox_Atribut = new System.Windows.Forms.TextBox();
            this.textBox_Element = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Validar = new System.Windows.Forms.Button();
            this.button_LlegirElements = new System.Windows.Forms.Button();
            this.button_RecorrerXML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.button_Next);
            this.groupBox1.Controls.Add(this.textBox_Atribut);
            this.groupBox1.Controls.Add(this.textBox_Element);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_Validar);
            this.groupBox1.Controls.Add(this.button_LlegirElements);
            this.groupBox1.Controls.Add(this.button_RecorrerXML);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacions";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(6, 180);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(923, 304);
            this.listBox.TabIndex = 10;
            // 
            // button_Next
            // 
            this.button_Next.Enabled = false;
            this.button_Next.Location = new System.Drawing.Point(356, 135);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(63, 34);
            this.button_Next.TabIndex = 9;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // textBox_Atribut
            // 
            this.textBox_Atribut.Location = new System.Drawing.Point(302, 102);
            this.textBox_Atribut.Name = "textBox_Atribut";
            this.textBox_Atribut.Size = new System.Drawing.Size(117, 26);
            this.textBox_Atribut.TabIndex = 8;
            // 
            // textBox_Element
            // 
            this.textBox_Element.Location = new System.Drawing.Point(302, 67);
            this.textBox_Element.Name = "textBox_Element";
            this.textBox_Element.Size = new System.Drawing.Size(117, 26);
            this.textBox_Element.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atriubut:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Element:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(764, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Generar Fitxer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Validar
            // 
            this.button_Validar.Location = new System.Drawing.Point(477, 25);
            this.button_Validar.Name = "button_Validar";
            this.button_Validar.Size = new System.Drawing.Size(159, 34);
            this.button_Validar.TabIndex = 2;
            this.button_Validar.Text = "Validar amb DTD";
            this.button_Validar.UseVisualStyleBackColor = true;
            this.button_Validar.Click += new System.EventHandler(this.button_Validar_Click);
            // 
            // button_LlegirElements
            // 
            this.button_LlegirElements.Location = new System.Drawing.Point(219, 25);
            this.button_LlegirElements.Name = "button_LlegirElements";
            this.button_LlegirElements.Size = new System.Drawing.Size(200, 34);
            this.button_LlegirElements.TabIndex = 1;
            this.button_LlegirElements.Text = "Llegir elements concrets";
            this.button_LlegirElements.UseVisualStyleBackColor = true;
            this.button_LlegirElements.Click += new System.EventHandler(this.button_LlegirElements_Click);
            // 
            // button_RecorrerXML
            // 
            this.button_RecorrerXML.Location = new System.Drawing.Point(6, 25);
            this.button_RecorrerXML.Name = "button_RecorrerXML";
            this.button_RecorrerXML.Size = new System.Drawing.Size(159, 34);
            this.button_RecorrerXML.TabIndex = 0;
            this.button_RecorrerXML.Text = "Recorrer XML";
            this.button_RecorrerXML.UseVisualStyleBackColor = true;
            this.button_RecorrerXML.Click += new System.EventHandler(this.button_RecorrerXML_Click);
            // 
            // frmXmlReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 533);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXmlReader";
            this.Text = "Xml Reader";
            this.Load += new System.EventHandler(this.frmXmlReader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Validar;
        private System.Windows.Forms.Button button_LlegirElements;
        private System.Windows.Forms.Button button_RecorrerXML;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.TextBox textBox_Atribut;
        private System.Windows.Forms.TextBox textBox_Element;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}