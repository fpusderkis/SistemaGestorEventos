
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
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuario,
            this.mnuIdioma});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 1;
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
            this.mnuUsuario.Size = new System.Drawing.Size(59, 20);
            this.mnuUsuario.Text = "Usuario";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(184, 22);
            this.mnuLogin.Text = "Iniciar Sesión";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(184, 22);
            this.mnuLogout.Text = "Cerrar sesión";
            this.mnuLogout.Visible = false;
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuRegistrar
            // 
            this.mnuRegistrar.Name = "mnuRegistrar";
            this.mnuRegistrar.Size = new System.Drawing.Size(184, 22);
            this.mnuRegistrar.Text = "Registrar";
            this.mnuRegistrar.Click += new System.EventHandler(this.mnuRegistrar_Click);
            // 
            // admnistrarPermisosToolStripMenuItem
            // 
            this.admnistrarPermisosToolStripMenuItem.Name = "admnistrarPermisosToolStripMenuItem";
            this.admnistrarPermisosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.admnistrarPermisosToolStripMenuItem.Text = "Admnistrar Permisos";
            this.admnistrarPermisosToolStripMenuItem.Visible = false;
            this.admnistrarPermisosToolStripMenuItem.Click += new System.EventHandler(this.admnistrarPermisosToolStripMenuItem_Click);
            // 
            // admnistrarUsuariosToolStripMenuItem
            // 
            this.admnistrarUsuariosToolStripMenuItem.Name = "admnistrarUsuariosToolStripMenuItem";
            this.admnistrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.admnistrarUsuariosToolStripMenuItem.Text = "Admnistrar Usuarios";
            this.admnistrarUsuariosToolStripMenuItem.Visible = false;
            this.admnistrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.admnistrarUsuariosToolStripMenuItem_Click);
            // 
            // mnuIdioma
            // 
            this.mnuIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCambiarIdioma});
            this.mnuIdioma.Name = "mnuIdioma";
            this.mnuIdioma.Size = new System.Drawing.Size(56, 20);
            this.mnuIdioma.Text = "Idioma";
            // 
            // mnuCambiarIdioma
            // 
            this.mnuCambiarIdioma.Name = "mnuCambiarIdioma";
            this.mnuCambiarIdioma.Size = new System.Drawing.Size(180, 22);
            this.mnuCambiarIdioma.Text = "Cambiar Idioma";
            this.mnuCambiarIdioma.Click += new System.EventHandler(this.mnuCambiarIdioma_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Se Hace!";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}