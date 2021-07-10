﻿using SistemaGestorEventos.BE;
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
            var usuario = new Usuario(this.txtUsername.Text,this.txtClave.Text,this.cmbIdioma.Text.ToString());

            try
            {
                sessionBLL.Register(usuario);
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
