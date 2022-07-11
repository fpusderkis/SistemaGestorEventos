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


        public FrmPrincipal()
        {
            InitializeComponent();
            
            SESSION.SuscribeSessionStatusChangeEvent(() => {
                this.mnuLogout.Visible = SESSION.IsLogged();
                bool esAdmin = SESSION.HasGrant(GrantType.AdministradorSistema);
                this.admnistrarPermisosToolStripMenuItem.Visible = esAdmin;
                this.admnistrarUsuariosToolStripMenuItem.Visible = esAdmin;
                if (SESSION.IsNotLogged())
                {
                    ShowFormAlone(new FrmLogin());
                } else
                {
                    ShowFormAlone(new Home.FrmHome());
                }
            });
            TraducirTextos();

            if (SESSION.IsNotLogged())
            {
                ShowFormAlone(new FrmLogin());
            }

            MultiIdioma.SuscribeCambioDeIdiomaEvent(TraducirTextos);
        }

        private void PrepareForm(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.ControlBox = false;
            form.ShowIcon = false;
            form.Text = "";
            form.Activate();
            form.WindowState = FormWindowState.Maximized;
        }

        private void ShowFormAlone(Form form)
        {
            this.SuspendLayout();

            foreach (var child in this.MdiChildren)
            {
                child.Close();
            }
            PrepareForm(form);
            form.Show();
            this.ResumeLayout();
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
            ShowFormAlone(form);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            SessionBLL.GetInstance().Logout();
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
            ShowFormAlone(permisosForm);
        }

        private void admnistrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormAlone(new FrmAdmUsuarios());
        }

        private void mnuCambiarIdioma_Click(object sender, EventArgs e)
        {
            //popup
            new FrmCambiarIdioma().Show();
        }

        private void mnuLogo1_Click(object sender, EventArgs e)
        {

        }

        private void mnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
