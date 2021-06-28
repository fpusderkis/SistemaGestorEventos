using SistemaGestorEventos.BE.Permisos;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.GUI.Utils;
using SistemaGestorEventos.SharedServices.Multiidioma;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Idioma
{
    public partial class FrmCambiarIdioma : Form
    {
        private MultiIdiomaBLL multiIdiomaBLL = MultiIdiomaBLL.Instance;

        public FrmCambiarIdioma()
        {
            InitializeComponent();
            MultiIdioma.SuscribeCambioDeIdiomaEvent(this.TraducirForm);
        }

        private void TraducirForm()
        {
            WinformUtils.TraducirControl(this);
        }

        private void FrmCambiarIdioma_Load(object sender, EventArgs e)
        {
            
            cbxIdiomas.DisplayMember = "Descripcion";
            cbxIdiomas.DataSource = multiIdiomaBLL.GetAllIdiomas();
            cbxIdiomas.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxIdiomas.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxIdiomas.SelectedItem = null;

            btnGestionar.Visible = SessionHandler<TipoPermiso>.GetInstance.TienePermiso(TipoPermiso.AdministradorSistema);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarIdioma_Click(object sender, EventArgs e)
        {
            if (cbxIdiomas.SelectedItem != null)
            {
                MultiIdioma.CambiarIdioma(((SistemaGestorEventos.BE.Idioma)cbxIdiomas.SelectedItem).Id);
                Close();
            }
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            new FrmCrearEditarIdioma().Show();
            this.Close();
        }
    }
}
