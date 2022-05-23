
namespace SistemaGestorEventos.GUI
{
    partial class FrmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuLogo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.admnistrarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admnistrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCambiarIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.AutoSize = false;
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogo1,
            this.mnuUsuario,
            this.mnuIdioma});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuPrincipal.Size = new System.Drawing.Size(819, 77);
            this.mnuPrincipal.TabIndex = 1;
            // 
            // mnuLogo1
            // 
            this.mnuLogo1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuLogo1.AutoSize = false;
            this.mnuLogo1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuLogo1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuLogo1.Image = global::SistemaGestorEventos.GUI.Properties.Resources.logo73x73;
            this.mnuLogo1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuLogo1.ImageTransparentColor = System.Drawing.Color.White;
            this.mnuLogo1.Name = "mnuLogo1";
            this.mnuLogo1.Size = new System.Drawing.Size(80, 80);
            this.mnuLogo1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.mnuLogo1.Click += new System.EventHandler(this.mnuLogo1_Click);
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuLogout,
            this.mnuRegistrar,
            this.admnistrarPermisosToolStripMenuItem,
            this.admnistrarUsuariosToolStripMenuItem});
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(73, 73);
            this.mnuUsuario.Tag = "mnu.usuario";
            this.mnuUsuario.Text = "Usuario";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(227, 26);
            this.mnuLogin.Tag = "mnu.login";
            this.mnuLogin.Text = "Iniciar Sesión";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(227, 26);
            this.mnuLogout.Tag = "mnu.logout";
            this.mnuLogout.Text = "Cerrar sesión";
            this.mnuLogout.Visible = false;
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuRegistrar
            // 
            this.mnuRegistrar.Name = "mnuRegistrar";
            this.mnuRegistrar.Size = new System.Drawing.Size(227, 26);
            this.mnuRegistrar.Tag = "mnu.singin";
            this.mnuRegistrar.Text = "Registrar";
            this.mnuRegistrar.Click += new System.EventHandler(this.mnuRegistrar_Click);
            // 
            // admnistrarPermisosToolStripMenuItem
            // 
            this.admnistrarPermisosToolStripMenuItem.Name = "admnistrarPermisosToolStripMenuItem";
            this.admnistrarPermisosToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.admnistrarPermisosToolStripMenuItem.Tag = "mnu.admin.grants";
            this.admnistrarPermisosToolStripMenuItem.Text = "Admnistrar Permisos";
            this.admnistrarPermisosToolStripMenuItem.Visible = false;
            this.admnistrarPermisosToolStripMenuItem.Click += new System.EventHandler(this.admnistrarPermisosToolStripMenuItem_Click);
            // 
            // admnistrarUsuariosToolStripMenuItem
            // 
            this.admnistrarUsuariosToolStripMenuItem.Name = "admnistrarUsuariosToolStripMenuItem";
            this.admnistrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.admnistrarUsuariosToolStripMenuItem.Tag = "mnu.admin.users";
            this.admnistrarUsuariosToolStripMenuItem.Text = "Admnistrar Usuarios";
            this.admnistrarUsuariosToolStripMenuItem.Visible = false;
            this.admnistrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.admnistrarUsuariosToolStripMenuItem_Click);
            // 
            // mnuIdioma
            // 
            this.mnuIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCambiarIdioma});
            this.mnuIdioma.Name = "mnuIdioma";
            this.mnuIdioma.Size = new System.Drawing.Size(70, 73);
            this.mnuIdioma.Tag = "mnu.lang";
            this.mnuIdioma.Text = "Idioma";
            // 
            // mnuCambiarIdioma
            // 
            this.mnuCambiarIdioma.Name = "mnuCambiarIdioma";
            this.mnuCambiarIdioma.Size = new System.Drawing.Size(199, 26);
            this.mnuCambiarIdioma.Tag = "mnu.lang.change";
            this.mnuCambiarIdioma.Text = "Cambiar Idioma";
            this.mnuCambiarIdioma.Click += new System.EventHandler(this.mnuCambiarIdioma_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 918);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FrmPrincipal";
            this.Tag = "title.main";
            this.Text = "Se Hace!";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistrar;
        private System.Windows.Forms.ToolStripMenuItem mnuIdioma;
        private System.Windows.Forms.ToolStripMenuItem admnistrarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admnistrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCambiarIdioma;
        private System.Windows.Forms.ToolStripMenuItem mnuLogo1;
    }
}