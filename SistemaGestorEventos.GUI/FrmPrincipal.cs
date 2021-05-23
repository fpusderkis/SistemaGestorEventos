using SistemaGestorEventos.BE;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI
{
    public partial class FrmPrincipal : Form
    {
        private readonly SessionHandler<Usuario> SESSION = SessionHandler<Usuario>.GetInstance;
        public FrmPrincipal()
        {
            InitializeComponent();
            SESSION.SuscribeSessionStatusChangeEvent(() => {
                this.mnuLogin.Visible = SESSION.IsNotLogged();
                this.mnuLogout.Visible = SESSION.IsLogged();
                this.mnuRegistrar.Visible = SESSION.IsNotLogged();
            });
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
            SESSION.Logout();
        }

        private void mnuRegistrar_Click(object sender, EventArgs e)
        {
            var registrar = new usuario.FrmRegistrar();
            registrar.MdiParent = this;
            registrar.Show();
        }
    }
}
