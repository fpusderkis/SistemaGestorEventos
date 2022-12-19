using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Bitacora
{
    public partial class Bitacora : Form
    {


        public Bitacora()
        {
            InitializeComponent();
            dgvLogsCreationDate.Tag = "logs.table.date";
            dgvLogsMessage.Tag = "logs.table.message";
            dgvLogsUsername.Tag = "logs.table.username";
            dataGridView1.AutoGenerateColumns = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "dd/MM/yyyy";
            dtpFrom.Value = DateTime.Now.AddDays(-4).Date.AddTicks(-1);

            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "dd/MM/yyyy";
            dtpTo.Value = DateTime.Now.Date;



            WinformUtils.TraducirControl(this);
        } 

        private void btnFind_Click(object sender, EventArgs e)
        {

            string criticity = cmbCriticity.SelectedItem != null ? cmbCriticity.SelectedItem.ToString() : "";

            var lista = BitacoraBLL.GetInstance.SearchLogs(
                txtUsername.Text,
                dtpFrom.Value,
                dtpTo.Value,
                criticity);

            dataGridView1.DataSource = lista;

        }
    }
}
