using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.exceptions;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.usuario
{
    public partial class FrmChangePassword : Form
    {
        private UserBLL userBLL = UserBLL.Instance;

        public FrmChangePassword()
        {
            InitializeComponent();
            TraducirTextos();
            MultiLang.SubscribeChangeLangEvent(TraducirTextos);

        }

        private void TraducirTextos()
        {
            WinformUtils.TraducirControl(this);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtNewPassRepeat.Text))
            {
                MessageBox.Show(MultiLang.TranslateOrDefault("password.change.error.newpassmandatory", "Escriba la nueva contraseña"));
                return;
            }

            if (!txtNewPass.Text.Equals(txtNewPassRepeat.Text))
            {
                MessageBox.Show(MultiLang.TranslateOrDefault("password.change.error.newpassnotsame", "Las nuevas contraseñas no coinciden."));
                return;
            }
            try
            {
                userBLL.ResetUserPassword(txtUsername.Text, txtPassword.Text, txtNewPass.Text);
                MessageBox.Show(MultiLang.TranslateOrDefault("password.change.ok", "Clave cambiada correctamente"));
                this.Close();
            } catch (ValidationException ve)
            {
                MessageBox.Show(ve.Message);
            } catch (Exception ex) { throw ex; }
            

        }
    }
}
