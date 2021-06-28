using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Permisos;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.GUI.Idioma;
using SistemaGestorEventos.GUI.Permisos;
using SistemaGestorEventos.GUI.Utils;
using SistemaGestorEventos.SharedServices.Multiidioma;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI
{
    public partial class FrmPrincipal : Form
    {
        private readonly SessionHandler<TipoPermiso> SESSION = SessionHandler<TipoPermiso>.GetInstance;
        public FrmPrincipal()
        {
            InitializeComponent();
            SESSION.SuscribeSessionStatusChangeEvent(() => {
                this.mnuLogin.Visible = SESSION.IsNotLogged();
                this.mnuLogout.Visible = SESSION.IsLogged();
                this.mnuRegistrar.Visible = SESSION.IsNotLogged();
                bool esAdmin = SESSION.TienePermiso(TipoPermiso.AdministradorSistema);
                this.admnistrarPermisosToolStripMenuItem.Visible = esAdmin;
                this.admnistrarUsuariosToolStripMenuItem.Visible = esAdmin;

            });

            MultiIdioma.SuscribeCambioDeIdiomaEvent(TraducirTextos);
        }

        

        private void TraducirTextos()
        {
            //this.mnuUsuario.Text = MultiIdioma.Traduccion("FrmPrincipal.mnuUsuario");
            //this.mnuLogin.Text = MultiIdioma.Traduccion("FrmPrincipal.mnuLogin");
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
            new FrmLogin().Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            SessionBLL.GetInstance().Logout();
        }

        private void mnuRegistrar_Click(object sender, EventArgs e)
        {
            var registrar = new usuario.FrmRegistrar();
            registrar.MdiParent = this;
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
            permisosForm.MdiParent = this;
            permisosForm.Show();
        }

        private void admnistrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmAdmUsuarios();
            form.MdiParent = this;
            
            form.Show();
        }

        private void mnuCambiarIdioma_Click(object sender, EventArgs e)
        {
            new FrmCambiarIdioma().Show();
        }
    }
}
