using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Grants;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.GUI.Idioma;
using SistemaGestorEventos.GUI.Permisos;
using SistemaGestorEventos.SharedServices.Multiidioma;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI
{
    public partial class FrmPrincipal : Form
    {
        private readonly SessionHandler SESSION = SessionHandler.GetInstance;

        private FrmLogin loginForm;

        public FrmPrincipal()
        {
            InitializeComponent();
            loginForm = new FrmLogin();
            PrepareForm(loginForm);
            
            SESSION.SuscribeSessionStatusChangeEvent(() => {
                this.mnuLogin.Visible = SESSION.IsNotLogged();
                this.mnuLogout.Visible = SESSION.IsLogged();
                this.mnuRegistrar.Visible = SESSION.IsNotLogged();
                bool esAdmin = SESSION.HasGrant(GrantType.AdministradorSistema);
                this.admnistrarPermisosToolStripMenuItem.Visible = esAdmin;
                this.admnistrarUsuariosToolStripMenuItem.Visible = esAdmin;

            });
            TraducirTextos();

            if (SESSION.IsNotLogged())
            {
                loginForm.Show();
            }

            MultiIdioma.SuscribeCambioDeIdiomaEvent(TraducirTextos);
        }

        private void PrepareForm(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ControlBox = false;
            form.ShowIcon = false;
            form.Text = "";
            loginForm.WindowState = FormWindowState.Maximized;
        }


        private void TraducirTextos()
        {
            WinformUtils.TraducirControl(this);
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            var form = new FrmLogin();
            PrepareForm(form);
            form.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            SessionBLL.GetInstance().Logout();
        }

        private void mnuRegistrar_Click(object sender, EventArgs e)
        {
            var registrar = new usuario.FrmRegistrar();
            PrepareForm(registrar);
            registrar.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            TraducirTextos();
        }

        private void mnuEditorIdioma_Click(object sender, EventArgs e)
        {

        }

        private void admnistrarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var permisosForm = new FrmAdminPermisos();
            PrepareForm(permisosForm);
            permisosForm.Show();
        }

        private void admnistrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmAdmUsuarios();
            PrepareForm(form);
            
            form.Show();
        }

        private void mnuCambiarIdioma_Click(object sender, EventArgs e)
        {
            //popup
            new FrmCambiarIdioma().Show();
        }

        private void mnuLogo1_Click(object sender, EventArgs e)
        {

        }
    }
}
