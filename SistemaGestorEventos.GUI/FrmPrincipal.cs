using PdfSharp.Drawing;
using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Grants;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.GUI.Idioma;
using SistemaGestorEventos.GUI.Lugares;
using SistemaGestorEventos.GUI.Permisos;
using SistemaGestorEventos.SharedServices;
using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.i18n;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI
{
    public partial class FrmPrincipal : Form
    {
        private readonly SessionHandler SESSION = SessionHandler.GetInstance;
        private bool integrity = false;

        public FrmPrincipal()
        {
            InitializeComponent();
            ShowMenus();
            SESSION.SuscribeSessionStatusChangeEvent(() => {
                this.mnuLogout.Visible = SESSION.IsLogged();
                bool esAdmin = SESSION.HasGrant(GrantType.AdministradorSistema);
                integrity = EventRoomBLL.Instance.ValidateDVV();

                if (!integrity && !esAdmin && SESSION.IsLogged())
                {
                    var errors = new List<string>();
                    errors.Add("Se encontro una o mas entidades corruptas. De aviso al administrador para continuar.");
                    WinformUtils.ShowErrorList("Base de datos corrupta", errors);
                    SESSION.Logout();
                    return;
                }

                ShowMenus();
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

            MultiLang.SubscribeChangeLangEvent(TraducirTextos);
        }

        private void ShowMenus()
        {
            bool esAdmin = SESSION.HasGrant(GrantType.AdministradorSistema);

            this.admnistrarPermisosToolStripMenuItem.Visible = esAdmin;
            this.admnistrarUsuariosToolStripMenuItem.Visible = esAdmin;
            this.administradorToolStripMenuItem.Visible = esAdmin;
            this.administradorToolStripMenuItem.Visible = SESSION.HasGrant(GrantType.AdministradorSistema);
            this.mnuUsuario.Visible = SESSION.IsLogged();
            this.bitacoraToolStripMenuItem.Visible = SESSION.HasGrant(GrantType.AdministradorSistema);
            this.homeToolStripMenuItem.Visible = SESSION.IsLogged();

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
            integrity = EventRoomBLL.Instance.ValidateDVV();
            if (!integrity)
            {
                var errors = new List<string>();
                errors.Add("Se encontro una o mas entidades corruptas. De aviso al administrador para continuar.");
                WinformUtils.ShowErrorList("Base de datos corrupta", errors);
            }
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

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bitacora.Bitacora().ShowDialog() ;
        }

        private void generarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = sfdSaveBackup.ShowDialog();

            if (DialogResult.OK == dr)
            {
                var fileName = sfdSaveBackup.FileName;
                try
                {
                    BackupBLL.Instance.MakeBackup(fileName);
                    MessageBox.Show(MultiLang.TranslateOrDefault("backup.generated.ok", "Backup generado con éxito."));
                } catch 
                {
                    MessageBox.Show(MultiLang.TranslateOrDefault("backup.generated.fail", "No fue posible restaurar el backup"));
                    BitacoraSingleton.Log($"No fue posible restaurar el backup {fileName}");
                }
                
                
                
            } 
        }


        private void restaurarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dr = this.ofdOpenBackupDB.ShowDialog();
            if (DialogResult.OK == dr && this.ofdOpenBackupDB.CheckFileExists)
            {
                try
                {
                    BackupBLL.Instance.RestoreBackup(this.ofdOpenBackupDB.FileName);

                    MessageBox.Show(MultiLang.TranslateOrDefault("backup.restored.ok", "Backup restaurado con éxito."));

                    this.Close();
                }
                catch
                {
                    MessageBox.Show(MultiLang.TranslateOrDefault("backup.restored.fail", "No fue posible restaurar el backup"));
                    BitacoraSingleton.Log($"No fue posible restaurar el backup {this.ofdOpenBackupDB.FileName}");
                }
                
            }
        }

        private void aBMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmServicos = new Services.ServicesFrm();
            frmServicos.ShowDialog();
        }

        private void lugaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPlaces = new FrmLugares();

            frmPlaces.ShowDialog();

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormAlone(new Home.FrmHome());
        }

        private void reporteEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
