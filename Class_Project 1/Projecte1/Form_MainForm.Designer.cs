namespace Projecte1
{
    partial class Form_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainForm));
            this.TopBar_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Max_button = new System.Windows.Forms.PictureBox();
            this.Close_button = new System.Windows.Forms.Button();
            this.LeftMenu_panel = new System.Windows.Forms.Panel();
            this.panel_Botones = new System.Windows.Forms.Panel();
            this.button_CerrarSesión = new System.Windows.Forms.Button();
            this.button_VerPerfil = new System.Windows.Forms.Button();
            this.pictureBox_tresbotones = new System.Windows.Forms.PictureBox();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.label_nombre_usuario = new System.Windows.Forms.Label();
            this.pictureBoxusuarios = new System.Windows.Forms.PictureBox();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.pictureBox_menu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_button)).BeginInit();
            this.LeftMenu_panel.SuspendLayout();
            this.panel_Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tresbotones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxusuarios)).BeginInit();
            this.Main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar_panel
            // 
            this.TopBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.TopBar_panel.Controls.Add(this.pictureBox1);
            this.TopBar_panel.Controls.Add(this.Max_button);
            this.TopBar_panel.Controls.Add(this.Close_button);
            resources.ApplyResources(this.TopBar_panel, "TopBar_panel");
            this.TopBar_panel.Name = "TopBar_panel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = global::Main.Resources.Min_Icon;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Max_button
            // 
            resources.ApplyResources(this.Max_button, "Max_button");
            this.Max_button.BackgroundImage = global::Main.Resources.Max_Icon;
            this.Max_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Max_button.Name = "Max_button";
            this.Max_button.TabStop = false;
            this.Max_button.Click += new System.EventHandler(this.Max_button_Click);
            // 
            // Close_button
            // 
            resources.ApplyResources(this.Close_button, "Close_button");
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.Close_button.BackgroundImage = global::Main.Resources.close;
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.Close_button.Name = "Close_button";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // LeftMenu_panel
            // 
            this.LeftMenu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.LeftMenu_panel.Controls.Add(this.panel_Botones);
            this.LeftMenu_panel.Controls.Add(this.pictureBox_tresbotones);
            this.LeftMenu_panel.Controls.Add(this.PanelOpciones);
            this.LeftMenu_panel.Controls.Add(this.label_nombre_usuario);
            this.LeftMenu_panel.Controls.Add(this.pictureBoxusuarios);
            resources.ApplyResources(this.LeftMenu_panel, "LeftMenu_panel");
            this.LeftMenu_panel.Name = "LeftMenu_panel";
            // 
            // panel_Botones
            // 
            this.panel_Botones.Controls.Add(this.button_CerrarSesión);
            this.panel_Botones.Controls.Add(this.button_VerPerfil);
            resources.ApplyResources(this.panel_Botones, "panel_Botones");
            this.panel_Botones.Name = "panel_Botones";
            // 
            // button_CerrarSesión
            // 
            this.button_CerrarSesión.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.button_CerrarSesión, "button_CerrarSesión");
            this.button_CerrarSesión.Name = "button_CerrarSesión";
            this.button_CerrarSesión.UseVisualStyleBackColor = false;
            this.button_CerrarSesión.Click += new System.EventHandler(this.button_CerrarSesión_Click);
            // 
            // button_VerPerfil
            // 
            this.button_VerPerfil.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.button_VerPerfil, "button_VerPerfil");
            this.button_VerPerfil.Name = "button_VerPerfil";
            this.button_VerPerfil.UseVisualStyleBackColor = false;
            this.button_VerPerfil.Click += new System.EventHandler(this.button_VerPerfil_Click);
            // 
            // pictureBox_tresbotones
            // 
            this.pictureBox_tresbotones.BackgroundImage = global::Main.Resources.puntos;
            resources.ApplyResources(this.pictureBox_tresbotones, "pictureBox_tresbotones");
            this.pictureBox_tresbotones.Name = "pictureBox_tresbotones";
            this.pictureBox_tresbotones.TabStop = false;
            this.pictureBox_tresbotones.Click += new System.EventHandler(this.pictureBox_tresbotones_Click);
            // 
            // PanelOpciones
            // 
            resources.ApplyResources(this.PanelOpciones, "PanelOpciones");
            this.PanelOpciones.Name = "PanelOpciones";
            // 
            // label_nombre_usuario
            // 
            resources.ApplyResources(this.label_nombre_usuario, "label_nombre_usuario");
            this.label_nombre_usuario.ForeColor = System.Drawing.Color.White;
            this.label_nombre_usuario.Name = "label_nombre_usuario";
            // 
            // pictureBoxusuarios
            // 
            resources.ApplyResources(this.pictureBoxusuarios, "pictureBoxusuarios");
            this.pictureBoxusuarios.Name = "pictureBoxusuarios";
            this.pictureBoxusuarios.TabStop = false;
            // 
            // Main_panel
            // 
            this.Main_panel.Controls.Add(this.pictureBox_menu);
            this.Main_panel.Controls.Add(this.panel1);
            resources.ApplyResources(this.Main_panel, "Main_panel");
            this.Main_panel.Name = "Main_panel";
            // 
            // pictureBox_menu
            // 
            this.pictureBox_menu.BackgroundImage = global::Main.Resources.menu;
            resources.ApplyResources(this.pictureBox_menu, "pictureBox_menu");
            this.pictureBox_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_menu.Name = "pictureBox_menu";
            this.pictureBox_menu.TabStop = false;
            this.pictureBox_menu.Click += new System.EventHandler(this.pictureBox_menu_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Form_MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.LeftMenu_panel);
            this.Controls.Add(this.TopBar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MainForm";
            this.Load += new System.EventHandler(this.Form_MainForm_Load);
            this.TopBar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_button)).EndInit();
            this.LeftMenu_panel.ResumeLayout(false);
            this.LeftMenu_panel.PerformLayout();
            this.panel_Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tresbotones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxusuarios)).EndInit();
            this.Main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar_panel;
        private System.Windows.Forms.Panel LeftMenu_panel;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Max_button;
        private System.Windows.Forms.PictureBox pictureBoxusuarios;
        private System.Windows.Forms.Label label_nombre_usuario;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.PictureBox pictureBox_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.PictureBox pictureBox_tresbotones;
        private System.Windows.Forms.Panel panel_Botones;
        private System.Windows.Forms.Button button_CerrarSesión;
        private System.Windows.Forms.Button button_VerPerfil;
    }
}