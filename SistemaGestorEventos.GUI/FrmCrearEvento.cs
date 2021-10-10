using SistemaGestorEventos.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI
{
    public partial class FrmCrearEvento : Form
    {
        private Evento evento = null;
        public FrmCrearEvento()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCrearEvento_Load(object sender, EventArgs e)
        {
            evento = new Evento();
            evento.Participantes.Add(new Participante());
            var binding = new BindingSource();
            binding.DataSource = evento.Participantes;
            binding.AllowNew = true;
            
            this.gvParticipantes.AutoGenerateColumns = false;
            this.gvParticipantes.DataSource = binding;

        }

        private void btnBuscarLugar_Click(object sender, EventArgs e)
        {
            new Lugares.BuscarLugares().Show();
        }
    }
}
