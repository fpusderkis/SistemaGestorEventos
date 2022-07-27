using SistemaGestorEventos.BLL;
using SistemaGestorEventos.BLL.Exceptions;
using SistemaGestorEventos.GUI.usuario;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI
{
    public partial class FrmLogin : Form
    {
        private SessionBLL sessionBLL = SessionBLL.GetInstance();

        public FrmLogin()
        {
            InitializeComponent();

            this.lblError.AutoSize = true;
            this.lblError.MaximumSize = new System.Drawing.Size(300, 0);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = sessionBLL.Login(this.txtUsername.Text, this.txtPassword.Text);

                this.Close();

            }
            catch (PasswordExpiredException ex)
            {
                var changeForm = new FrmChangePassword();
                changeForm.Text = MultiLang.TranslateOrDefault(ex.MessageKey, ex.MessageText);
                changeForm.ShowDialog();
            }
            catch (BLL.Exceptions.BusinessException ex)
            {
                this.lblError.Text = MultiLang.TranslateOrDefault(ex.MessageKey,ex.MessageText);
                this.lblError.Visible = true;
            }
           
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            gbxLogin.Left = (gbxLogin.Parent.Width - gbxLogin.Width) / 2;
            gbxLogin.Top = (gbxLogin.Parent.Height - gbxLogin.Height) / 2;
        }
    }
}
