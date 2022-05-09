
using System.Collections.Immutable;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI
{
    partial class MainUI
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubmenuAdministrador = new System.Windows.Forms.Panel();
            this.mnuAdministrarIdiomas = new System.Windows.Forms.Button();
            this.mnuAdministrarUsuarios = new System.Windows.Forms.Button();
            this.mnuAdministrarPermisos = new System.Windows.Forms.Button();
            this.mnuAdministrador = new System.Windows.Forms.Button();
            this.panelSubUsuario = new System.Windows.Forms.Panel();
            this.mnuCambiarIdioma = new System.Windows.Forms.Button();
            this.mnuRegistrarUsuario = new System.Windows.Forms.Button();
            this.mnuCerrarSesion = new System.Windows.Forms.Button();
            this.mnuLogin = new System.Windows.Forms.Button();
            this.btnMainUsuario = new System.Windows.Forms.Button();
            this.mnuHomeCrearEvento = new System.Windows.Forms.Button();
            this.mnuHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblTitelUsername = new System.Windows.Forms.Label();
            this.lblSeHace = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelSubmenuAdministrador.SuspendLayout();
            this.panelSubUsuario.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Controls.Add(this.panelSubmenuAdministrador);
            this.panelMenu.Controls.Add(this.mnuAdministrador);
            this.panelMenu.Controls.Add(this.panelSubUsuario);
            this.panelMenu.Controls.Add(this.btnMainUsuario);
            this.panelMenu.Controls.Add(this.mnuHomeCrearEvento);
            this.panelMenu.Controls.Add(this.mnuHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panelMenu.Size = new System.Drawing.Size(248, 804);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelMenu_ControlRemoved);
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelSubmenuAdministrador
            // 
            this.panelSubmenuAdministrador.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSubmenuAdministrador.Controls.Add(this.mnuAdministrarIdiomas);
            this.panelSubmenuAdministrador.Controls.Add(this.mnuAdministrarUsuarios);
            this.panelSubmenuAdministrador.Controls.Add(this.mnuAdministrarPermisos);
            this.panelSubmenuAdministrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuAdministrador.Location = new System.Drawing.Point(0, 587);
            this.panelSubmenuAdministrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSubmenuAdministrador.Name = "panelSubmenuAdministrador";
            this.panelSubmenuAdministrador.Size = new System.Drawing.Size(247, 193);
            this.panelSubmenuAdministrador.TabIndex = 2;
            // 
            // mnuAdministrarIdiomas
            // 
            this.mnuAdministrarIdiomas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuAdministrarIdiomas.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuAdministrarIdiomas.FlatAppearance.BorderSize = 0;
            this.mnuAdministrarIdiomas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuAdministrarIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuAdministrarIdiomas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdministrarIdiomas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuAdministrarIdiomas.Location = new System.Drawing.Point(0, 120);
            this.mnuAdministrarIdiomas.Margin = new System.Windows.Forms.Padding(0);
            this.mnuAdministrarIdiomas.Name = "mnuAdministrarIdiomas";
            this.mnuAdministrarIdiomas.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.mnuAdministrarIdiomas.Size = new System.Drawing.Size(247, 60);
            this.mnuAdministrarIdiomas.TabIndex = 8;
            this.mnuAdministrarIdiomas.Tag = "mnu.admin.lang";
            this.mnuAdministrarIdiomas.Text = "Gestor idiomas";
            this.mnuAdministrarIdiomas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuAdministrarIdiomas.UseVisualStyleBackColor = false;
            this.mnuAdministrarIdiomas.Click += new System.EventHandler(this.mnuAdministrarIdiomas_Click);
            // 
            // mnuAdministrarUsuarios
            // 
            this.mnuAdministrarUsuarios.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuAdministrarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuAdministrarUsuarios.FlatAppearance.BorderSize = 0;
            this.mnuAdministrarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuAdministrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuAdministrarUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdministrarUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuAdministrarUsuarios.Location = new System.Drawing.Point(0, 60);
            this.mnuAdministrarUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.mnuAdministrarUsuarios.Name = "mnuAdministrarUsuarios";
            this.mnuAdministrarUsuarios.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.mnuAdministrarUsuarios.Size = new System.Drawing.Size(247, 60);
            this.mnuAdministrarUsuarios.TabIndex = 7;
            this.mnuAdministrarUsuarios.Tag = "mnu.admin.users";
            this.mnuAdministrarUsuarios.Text = "Usuarios";
            this.mnuAdministrarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuAdministrarUsuarios.UseVisualStyleBackColor = false;
            this.mnuAdministrarUsuarios.Click += new System.EventHandler(this.mnuAdministrarUsuarios_Click);
            // 
            // mnuAdministrarPermisos
            // 
            this.mnuAdministrarPermisos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuAdministrarPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuAdministrarPermisos.FlatAppearance.BorderSize = 0;
            this.mnuAdministrarPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuAdministrarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuAdministrarPermisos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdministrarPermisos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuAdministrarPermisos.Location = new System.Drawing.Point(0, 0);
            this.mnuAdministrarPermisos.Margin = new System.Windows.Forms.Padding(0);
            this.mnuAdministrarPermisos.Name = "mnuAdministrarPermisos";
            this.mnuAdministrarPermisos.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.mnuAdministrarPermisos.Size = new System.Drawing.Size(247, 60);
            this.mnuAdministrarPermisos.TabIndex = 6;
            this.mnuAdministrarPermisos.Tag = "mnu.admin.grants";
            this.mnuAdministrarPermisos.Text = "Permisos";
            this.mnuAdministrarPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuAdministrarPermisos.UseVisualStyleBackColor = false;
            this.mnuAdministrarPermisos.Click += new System.EventHandler(this.mnuAdministrarPermisos_Click);
            // 
            // mnuAdministrador
            // 
            this.mnuAdministrador.BackColor = System.Drawing.SystemColors.Desktop;
            this.mnuAdministrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuAdministrador.FlatAppearance.BorderSize = 0;
            this.mnuAdministrador.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuAdministrador.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuAdministrador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuAdministrador.Location = new System.Drawing.Point(0, 527);
            this.mnuAdministrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mnuAdministrador.Name = "mnuAdministrador";
            this.mnuAdministrador.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.mnuAdministrador.Size = new System.Drawing.Size(247, 60);
            this.mnuAdministrador.TabIndex = 5;
            this.mnuAdministrador.Tag = "mnu.admin";
            this.mnuAdministrador.Text = "Administrador";
            this.mnuAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuAdministrador.UseVisualStyleBackColor = false;
            this.mnuAdministrador.Click += new System.EventHandler(this.mnuAdministrador_Click);
            // 
            // panelSubUsuario
            // 
            this.panelSubUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSubUsuario.Controls.Add(this.mnuCambiarIdioma);
            this.panelSubUsuario.Controls.Add(this.mnuRegistrarUsuario);
            this.panelSubUsuario.Controls.Add(this.mnuCerrarSesion);
            this.panelSubUsuario.Controls.Add(this.mnuLogin);
            this.panelSubUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubUsuario.Location = new System.Drawing.Point(0, 288);
            this.panelSubUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSubUsuario.Name = "panelSubUsuario";
            this.panelSubUsuario.Size = new System.Drawing.Size(247, 239);
            this.panelSubUsuario.TabIndex = 2;
            // 
            // mnuCambiarIdioma
            // 
            this.mnuCambiarIdioma.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuCambiarIdioma.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuCambiarIdioma.FlatAppearance.BorderSize = 0;
            this.mnuCambiarIdioma.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuCambiarIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuCambiarIdioma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuCambiarIdioma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuCambiarIdioma.Location = new System.Drawing.Point(0, 180);
            this.mnuCambiarIdioma.Margin = new System.Windows.Forms.Padding(0);
            this.mnuCambiarIdioma.Name = "mnuCambiarIdioma";
            this.mnuCambiarIdioma.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.mnuCambiarIdioma.Size = new System.Drawing.Size(247, 60);
            this.mnuCambiarIdioma.TabIndex = 4;
            this.mnuCambiarIdioma.Tag = "mnu.lang.change";
            this.mnuCambiarIdioma.Text = "Cambiar idioma";
            this.mnuCambiarIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuCambiarIdioma.UseVisualStyleBackColor = false;
            this.mnuCambiarIdioma.Click += new System.EventHandler(this.mnuCambiarIdioma_Click);
            // 
            // mnuRegistrarUsuario
            // 
            this.mnuRegistrarUsuario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuRegistrarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.mnuRegistrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuRegistrarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuRegistrarUsuario.Location = new System.Drawing.Point(0, 120);
            this.mnuRegistrarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.mnuRegistrarUsuario.Name = "mnuRegistrarUsuario";
            this.mnuRegistrarUsuario.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.mnuRegistrarUsuario.Size = new System.Drawing.Size(247, 60);
            this.mnuRegistrarUsuario.TabIndex = 3;
            this.mnuRegistrarUsuario.Tag = "mnu.register";
            this.mnuRegistrarUsuario.Text = "Registrarse";
            this.mnuRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuRegistrarUsuario.UseVisualStyleBackColor = false;
            this.mnuRegistrarUsuario.Click += new System.EventHandler(this.mnuRegistrarUsuario_Click);
            // 
            // mnuCerrarSesion
            // 
            this.mnuCerrarSesion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuCerrarSesion.FlatAppearance.BorderSize = 0;
            this.mnuCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuCerrarSesion.Location = new System.Drawing.Point(0, 60);
            this.mnuCerrarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.mnuCerrarSesion.Name = "mnuCerrarSesion";
            this.mnuCerrarSesion.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.mnuCerrarSesion.Size = new System.Drawing.Size(247, 60);
            this.mnuCerrarSesion.TabIndex = 2;
            this.mnuCerrarSesion.Tag = "mnu.logout";
            this.mnuCerrarSesion.Text = "Cerrar sesión";
            this.mnuCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuCerrarSesion.UseVisualStyleBackColor = false;
            this.mnuCerrarSesion.Click += new System.EventHandler(this.mnuCerrarSesion_Click);
            // 
            // mnuLogin
            // 
            this.mnuLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnuLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuLogin.FlatAppearance.BorderSize = 0;
            this.mnuLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuLogin.Location = new System.Drawing.Point(0, 0);
            this.mnuLogin.Margin = new System.Windows.Forms.Padding(0);
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.mnuLogin.Size = new System.Drawing.Size(247, 60);
            this.mnuLogin.TabIndex = 2;
            this.mnuLogin.Tag = "mnu.login";
            this.mnuLogin.Text = "Iniciar Sesión";
            this.mnuLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuLogin.UseVisualStyleBackColor = false;
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // btnMainUsuario
            // 
            this.btnMainUsuario.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMainUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainUsuario.FlatAppearance.BorderSize = 0;
            this.btnMainUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMainUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMainUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMainUsuario.Location = new System.Drawing.Point(0, 228);
            this.btnMainUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainUsuario.Name = "btnMainUsuario";
            this.btnMainUsuario.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnMainUsuario.Size = new System.Drawing.Size(247, 60);
            this.btnMainUsuario.TabIndex = 1;
            this.btnMainUsuario.Tag = "mnu.usuario";
            this.btnMainUsuario.Text = "Usuario";
            this.btnMainUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainUsuario.UseVisualStyleBackColor = false;
            this.btnMainUsuario.Click += new System.EventHandler(this.btnMainUsuario_Click);
            // 
            // mnuHomeCrearEvento
            // 
            this.mnuHomeCrearEvento.BackColor = System.Drawing.SystemColors.Desktop;
            this.mnuHomeCrearEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuHomeCrearEvento.FlatAppearance.BorderSize = 0;
            this.mnuHomeCrearEvento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuHomeCrearEvento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuHomeCrearEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuHomeCrearEvento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuHomeCrearEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuHomeCrearEvento.Location = new System.Drawing.Point(0, 168);
            this.mnuHomeCrearEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mnuHomeCrearEvento.Name = "mnuHomeCrearEvento";
            this.mnuHomeCrearEvento.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.mnuHomeCrearEvento.Size = new System.Drawing.Size(247, 60);
            this.mnuHomeCrearEvento.TabIndex = 1;
            this.mnuHomeCrearEvento.Tag = "mnu.newevent";
            this.mnuHomeCrearEvento.Text = "Crear evento";
            this.mnuHomeCrearEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuHomeCrearEvento.UseVisualStyleBackColor = false;
            this.mnuHomeCrearEvento.Click += new System.EventHandler(this.mnuHomeCrearEvento_Click);
            // 
            // mnuHome
            // 
            this.mnuHome.BackColor = System.Drawing.SystemColors.Desktop;
            this.mnuHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuHome.FlatAppearance.BorderSize = 0;
            this.mnuHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.mnuHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuHome.Location = new System.Drawing.Point(0, 108);
            this.mnuHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.mnuHome.Size = new System.Drawing.Size(247, 60);
            this.mnuHome.TabIndex = 1;
            this.mnuHome.Tag = "mnu.home";
            this.mnuHome.Text = "Home";
            this.mnuHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuHome.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblTitelUsername);
            this.panelLogo.Controls.Add(this.lblSeHace);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(247, 108);
            this.panelLogo.TabIndex = 0;
            // 
            // lblTitelUsername
            // 
            this.lblTitelUsername.AutoSize = true;
            this.lblTitelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitelUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitelUsername.Location = new System.Drawing.Point(14, 60);
            this.lblTitelUsername.Name = "lblTitelUsername";
            this.lblTitelUsername.Size = new System.Drawing.Size(0, 28);
            this.lblTitelUsername.TabIndex = 1;
            // 
            // lblSeHace
            // 
            this.lblSeHace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeHace.AutoSize = true;
            this.lblSeHace.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeHace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSeHace.Location = new System.Drawing.Point(41, 0);
            this.lblSeHace.Name = "lblSeHace";
            this.lblSeHace.Size = new System.Drawing.Size(178, 54);
            this.lblSeHace.TabIndex = 0;
            this.lblSeHace.Tag = "title.doit";
            this.lblSeHace.Text = "Se hace!";
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(248, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(817, 804);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            this.panelContenedor.Resize += new System.EventHandler(this.panelContenedor_Resize);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 804);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1083, 851);
            this.MinimumSize = new System.Drawing.Size(1083, 851);
            this.Name = "MainUI";
            this.Tag = "main.title";
            this.Text = "Se Hace!";
            this.panelMenu.ResumeLayout(false);
            this.panelSubmenuAdministrador.ResumeLayout(false);
            this.panelSubUsuario.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMainUsuario;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubUsuario;
        private System.Windows.Forms.Button mnuLogin;
        private System.Windows.Forms.Panel panelSubmenuAdministrador;
        private System.Windows.Forms.Button mnuAdministrarIdiomas;
        private System.Windows.Forms.Button mnuAdministrarUsuarios;
        private System.Windows.Forms.Button mnuAdministrarPermisos;
        private System.Windows.Forms.Button mnuAdministrador;
        private System.Windows.Forms.Button mnuCambiarIdioma;
        private System.Windows.Forms.Button mnuRegistrarUsuario;
        private System.Windows.Forms.Button mnuCerrarSesion;
        private System.Windows.Forms.Panel panelContenedor;

        private System.Windows.Forms.Button mnuHome;
        private System.Windows.Forms.Button mnuHomeCrearEvento;
        private Label lblSeHace;
        private Label lblTitelUsername;
    }
}