namespace Projecte1
{
    partial class Form_Login
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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.IncorrectPassword_label = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.Enter_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserIcon_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(143, 68);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(253, 20);
            this.textBox_username.TabIndex = 1;
            this.textBox_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_username_KeyPress);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(143, 110);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(253, 20);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_password_KeyPress);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Name.Location = new System.Drawing.Point(42, 9);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(216, 38);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Iniciar sesión";
            // 
            // IncorrectPassword_label
            // 
            this.IncorrectPassword_label.AutoSize = true;
            this.IncorrectPassword_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectPassword_label.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPassword_label.Location = new System.Drawing.Point(86, 137);
            this.IncorrectPassword_label.Name = "IncorrectPassword_label";
            this.IncorrectPassword_label.Size = new System.Drawing.Size(0, 17);
            this.IncorrectPassword_label.TabIndex = 9;
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Close_button.BackgroundImage = global::Main.Resources.Close_Icon;
            this.Close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Close_button.Location = new System.Drawing.Point(444, 4);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(18, 19);
            this.Close_button.TabIndex = 10;
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            this.Close_button.MouseLeave += new System.EventHandler(this.Close_button_MouseLeave);
            this.Close_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_button_MouseMove);
            // 
            // Enter_button
            // 
            this.Enter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Enter_button.BackgroundImage = global::Main.Resources.Check_Icon;
            this.Enter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Enter_button.Location = new System.Drawing.Point(434, 150);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(26, 25);
            this.Enter_button.TabIndex = 8;
            this.Enter_button.UseVisualStyleBackColor = false;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            this.Enter_button.MouseLeave += new System.EventHandler(this.Enter_button_MouseLeave);
            this.Enter_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Enter_button_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Main.Resources.Password;
            this.pictureBox2.Location = new System.Drawing.Point(89, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Main.Resources.UserIconHeader;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UserIcon_pictureBox
            // 
            this.UserIcon_pictureBox.Image = global::Main.Resources.UserIcon;
            this.UserIcon_pictureBox.Location = new System.Drawing.Point(89, 61);
            this.UserIcon_pictureBox.Name = "UserIcon_pictureBox";
            this.UserIcon_pictureBox.Size = new System.Drawing.Size(32, 32);
            this.UserIcon_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserIcon_pictureBox.TabIndex = 4;
            this.UserIcon_pictureBox.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(467, 181);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.IncorrectPassword_label);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.UserIcon_pictureBox);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.PictureBox UserIcon_pictureBox;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Label IncorrectPassword_label;
        private System.Windows.Forms.Button Close_button;
    }
}