using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;

namespace SistemaGestorEventos.GUI.Services
{
    public partial class ServicesFrm : Form
    {
        private Service service;
        private AditionalServicesBLL aditionalServicesBLL = AditionalServicesBLL.Instance;
        public ServicesFrm()
        {
            InitializeComponent();
            this.service = new Service();
            var c = ServiceComponent.CreateFrom(service);
            groupBox1.Controls.Add(c);
            dataGridView1.AutoGenerateColumns = false;
        }

        private void ServicesFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchService_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aditionalServicesBLL.FindServicesByName(service.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                this.SuspendLayout();
                groupBox1.Controls.Clear();
                this.service = (Service)dataGridView1.SelectedRows[0].DataBoundItem;
                groupBox1.Controls.Add(ServiceComponent.CreateFrom(this.service));
                this.ResumeLayout();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.aditionalServicesBLL.SaveService(this.service);
            btnNew_Click(null, null);
            btnSearchService_Click(null, null);
            MessageBox.Show("Ok");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            groupBox1.Controls.Clear();
            this.service = new Service();
            groupBox1.Controls.Add(ServiceComponent.CreateFrom(this.service));
            this.ResumeLayout();
        }
    }
}
