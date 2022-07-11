using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Home
{
    public partial class FrmHome : Form
    {

        private CustomerBLL customerBLL = CustomerBLL.Instance;
        public FrmHome()
        {
            InitializeComponent();
            MultiIdioma.SuscribeCambioDeIdiomaEvent(Translate);

        }

        private void Translate()
        {
            WinformUtils.TraducirControl(this);
            dgvCustomers.Columns[1].HeaderText = MultiIdioma.TranslateOrDefault("home.custommers.taxPayerId", "CUIL/CUIT");
            dgvCustomers.Columns[2].HeaderText = MultiIdioma.TranslateOrDefault("home.custommers.name", "Nombre");
            dgvCustomers.Columns[3].HeaderText = MultiIdioma.TranslateOrDefault("home.custommers.mail", "Mail");
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            var form = new Events.EventForm();
            form.ShowDialog();
        }

        private void btnAttendNew_Click(object sender, EventArgs e)
        {
            var dialogResult = new Custommers.FrmRegisterCustomer().ShowDialog();
        }

        private void btnFindCx_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerBLL.FindCustomer(txtTaxId.Text, txtMail.Text, txtName.Text);

            dgvCustomers.SuspendLayout();
            dgvCustomers.Rows.Clear();
            
            if (customers != null)
            foreach (Customer customer in customers)
            {
                String name = $"{customer.Name} {customer.LastName}";
                int n = dgvCustomers.Rows.Add();

                dgvCustomers.Rows[n].Cells[0].Value = customer.Id;
                dgvCustomers.Rows[n].Cells[1].Value = customer.TaxPayerId;
                dgvCustomers.Rows[n].Cells[2].Value = customer.Name + " " + customer.LastName;
                dgvCustomers.Rows[n].Cells[3].Value = customer.Mail;
                
            }

            dgvCustomers.ResumeLayout();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 1)
            {
                String taxPayerId = (string)dgvCustomers.SelectedRows[0].Cells[1].Value;
                var customer = customerBLL.FindCustomer(taxPayerId, null, null)[0];

                var editCustommer = new Custommers.FrmRegisterCustomer();
                editCustommer.EditCustomer(customer);
                editCustommer.ShowDialog();
            }
        }
    }
}
