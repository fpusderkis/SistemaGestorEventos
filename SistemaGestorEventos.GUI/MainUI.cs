using SistemaGestorEventos.BE.Permisos;
using SistemaGestorEventos.GUI.Idioma;
using SistemaGestorEventos.SharedServices.Multiidioma;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI
{
    public partial class MainUI : Form
    {
        private readonly SessionHandler<TipoPermiso> SESSION = SessionHandler<TipoPermiso>.GetInstance;
        private Form activeForm = null;

        public MainUI()
        {
            InitializeComponent();
            TraducirTextos();
            SessionChangeEvent();
            
            

            SESSION.SuscribeSessionStatusChangeEvent(SessionChangeEvent);
            MultiIdioma.SuscribeCambioDeIdiomaEvent(TraducirTextos);

        }
        
        private void SessionChangeEvent()
        {
            this.SuspendLayout();
            


            WinformUtils.HacerVisibles(this.panelMenu);
            bool esAdmin = SESSION.TienePermiso(TipoPermiso.AdministradorSistema);


            this.mnuAdministrador.Visible = esAdmin;


            this.mnuLogin.Visible = SESSION.IsNotLogged();
            this.mnuCerrarSesion.Visible = SESSION.IsLogged();
            this.mnuRegistrarUsuario.Visible = SESSION.IsNotLogged();
            

            hideMenuPanels();

            if (SESSION.IsLogged())
            {
                lblTitelUsername.Text = SESSION.Usuario.Username;
                lblTitelUsername.Visible = true;
            } else
            {
                lblTitelUsername.Visible = false;
            }
            this.ResumeLayout();
        }

        private void MenuLifeHack()
        {
            /// NO se porque pasa que cambia de posici[on los componentes, pero con este lifehack se arregla.

            this.panelMenu.Controls.Clear();

            this.panelMenu.Controls.Add(this.panelSubmenuAdministrador);
            this.panelMenu.Controls.Add(this.mnuAdministrador);
            this.panelMenu.Controls.Add(this.panelSubUsuario);
            this.panelMenu.Controls.Add(this.btnMainUsuario);
            this.panelMenu.Controls.Add(this.mnuHomeCrearEvento);
            this.panelMenu.Controls.Add(this.mnuHome);
            this.panelMenu.Controls.Add(this.panelLogo);
        }

        private void TraducirTextos()
        {
            WinformUtils.TraducirControl(this);
        }

        private void hideMenuPanels()
        {
            
            this.panelSubUsuario.Visible = false;
            this.panelSubmenuAdministrador.Visible = false;

            SortByTabIndex();
        }

        private void SortByTabIndex()
        {
            if (this.panelMenu != null)
            {

            }
        }

        private void collapseMenu(Panel panelMenu)
        {
            if (panelMenu.Visible == true)
            {
                panelMenu.Visible = false;
            } else
            {
                hideMenuPanels();
                panelMenu.Visible = true;
            }

        }

        private void btnMainUsuario_Click(object sender, EventArgs e)
        {
            collapseMenu(this.panelSubUsuario);
        }

        private void mnuAdministrador_Click(object sender, EventArgs e)
        {
            collapseMenu(this.panelSubmenuAdministrador);
        }

        private void openChildForm(Form form)
        {
            this.SuspendLayout();

            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            
            

            if (this.activeForm != null)
            {
                this.activeForm.Close();
            }

            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(form);
            
            form.Dock = DockStyle.Fill;
            form.AutoSize = true;
            form.MaximizeBox = true;
            form.Parent = this.panelContenedor;
            form.BringToFront();
            this.activeForm = form;
            WinformUtils.TraducirControl(form);
            form.Show();
            this.ResumeLayout();
        }

        private void mnuAdministrarIdiomas_Click(object sender, EventArgs e)
        {
            openChildForm(new Idioma.FrmCrearEditarIdioma());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelMenu.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);

        }

        private void mnuAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Permisos.FrmAdmUsuarios());
        }

        private void mnuAdministrarPermisos_Click(object sender, EventArgs e)
        {
            openChildForm(new Permisos.FrmAdminPermisos());

        }

        private void mnuCambiarIdioma_Click(object sender, EventArgs e)
        {
            new FrmCambiarIdioma().Show();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmLogin());
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.SESSION.Logout();
        }

        private void mnuRegistrarUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new usuario.FrmRegistrar());
        }

        private void panelMenu_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e != null)
            {

            }
        }

        private void mnuHomeCrearEvento_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCrearEvento());
        }

        private void panelContenedor_Resize(object sender, EventArgs e)
        {
            if (this.activeForm != null)
            {
                this.activeForm.Dock = DockStyle.Fill;
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
