using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.Multiidioma;
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                var usuario = sessionBLL.Login(this.txtUsername.Text, this.txtPassword.Text);
                if (usuario != null)
                {
                    this.Close();
                } else
                {
                    this.lblError.Visible = true;
                }
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
    }
}
