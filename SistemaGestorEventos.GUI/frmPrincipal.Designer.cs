
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
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.admnistrarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admnistrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCambiarIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lugaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSaveBackup = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenBackupDB = new System.Windows.Forms.OpenFileDialog();
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
            this.mnuIdioma,
            this.bitacoraToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuPrincipal.Size = new System.Drawing.Size(960, 77);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuPrincipal_ItemClicked);
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
            this.mnuLogout,
            this.admnistrarPermisosToolStripMenuItem,
            this.admnistrarUsuariosToolStripMenuItem});
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(73, 73);
            this.mnuUsuario.Tag = "mnu.usuario";
            this.mnuUsuario.Text = "Usuario";
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
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(78, 73);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarBackupToolStripMenuItem,
            this.restaurarBackupToolStripMenuItem,
            this.aBMCToolStripMenuItem,
            this.lugaresToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(118, 73);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // generarBackupToolStripMenuItem
            // 
            this.generarBackupToolStripMenuItem.Name = "generarBackupToolStripMenuItem";
            this.generarBackupToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.generarBackupToolStripMenuItem.Text = "Generar backup";
            this.generarBackupToolStripMenuItem.Click += new System.EventHandler(this.generarBackupToolStripMenuItem_Click);
            // 
            // restaurarBackupToolStripMenuItem
            // 
            this.restaurarBackupToolStripMenuItem.Name = "restaurarBackupToolStripMenuItem";
            this.restaurarBackupToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.restaurarBackupToolStripMenuItem.Text = "Restaurar backup";
            this.restaurarBackupToolStripMenuItem.Click += new System.EventHandler(this.restaurarBackupToolStripMenuItem_Click);
            // 
            // aBMCToolStripMenuItem
            // 
            this.aBMCToolStripMenuItem.Name = "aBMCToolStripMenuItem";
            this.aBMCToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.aBMCToolStripMenuItem.Text = "Servicios";
            this.aBMCToolStripMenuItem.Click += new System.EventHandler(this.aBMCToolStripMenuItem_Click);
            // 
            // lugaresToolStripMenuItem
            // 
            this.lugaresToolStripMenuItem.Name = "lugaresToolStripMenuItem";
            this.lugaresToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.lugaresToolStripMenuItem.Text = "Lugares";
            this.lugaresToolStripMenuItem.Click += new System.EventHandler(this.lugaresToolStripMenuItem_Click);
            // 
            // sfdSaveBackup
            // 
            this.sfdSaveBackup.DefaultExt = "bak";
            this.sfdSaveBackup.Filter = "SQL backup files (*.bak)|*.bak";
            // 
            // ofdOpenBackupDB
            // 
            this.ofdOpenBackupDB.DefaultExt = "bak";
            this.ofdOpenBackupDB.Filter = "SQL backup files (*.bak)|*.bak";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 918);
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
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuIdioma;
        private System.Windows.Forms.ToolStripMenuItem admnistrarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admnistrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCambiarIdioma;
        private System.Windows.Forms.ToolStripMenuItem mnuLogo1;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBackupToolStripMenuItem;

        private System.Windows.Forms.SaveFileDialog sfdSaveBackup;
        private System.Windows.Forms.OpenFileDialog ofdOpenBackupDB;
        private System.Windows.Forms.ToolStripMenuItem aBMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lugaresToolStripMenuItem;
    }
}