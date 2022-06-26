using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.exceptions;
using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.usuario
{
    public partial class FrmRegistrar : Form
    {
        private readonly SessionBLL sessionBLL = SessionBLL.GetInstance();
        private readonly UserBLL userBLL = UserBLL.Instance;

        public FrmRegistrar()
        {
            InitializeComponent();
            MultiIdioma.SuscribeCambioDeIdiomaEvent(TraducirTextos);
        }

        private void TraducirTextos()
        {
            WinformUtils.TraducirControl(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var usuario = new User(this.txtUsername.Text,this.txtClave.Text);
            usuario.Phone = txtTelefono.Text;
            usuario.Mail = txtEmail.Text;
            usuario.Name = txtName.Text;
            usuario.Lastname = txtLastname.Text;

            try
            {
                userBLL.Register(usuario);
                MessageBox.Show(MultiIdioma.TranslateOrDefault("register.success", "Usuario dado de alta correctamente."));
                this.Close();
            } catch (ValidationException ve)
            {
                this.lblError.Text = ve.Message;
            }


        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {
            TraducirTextos();
        }
    }
}
