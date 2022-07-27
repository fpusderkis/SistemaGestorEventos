using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Custommers
{
    public partial class FrmRegisterCustomer : Form
    {
        private Customer customer = new Customer();

        private CustomerBLL customerBLL = CustomerBLL.Instance;

        public FrmRegisterCustomer()
        {
            InitializeComponent();
            Translate();
            MultiLang.SubscribeChangeLangEvent(Translate);

        }

        public void EditCustomer(Customer c)
        {
            this.customer = c;
        }

        private void Translate()
        {
            WinformUtils.TraducirControl(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var errors = customerBLL.SaveCustomer(this.customer);
            if (errors.Count > 0)
            {
                WinformUtils.ShowErrorList(
                    MultiLang.TranslateOrDefault("errors.customer.errortitle", "No fue posible guardar el cliente")
                    , errors);
            } else {
                MessageBox.Show(MultiLang.TranslateOrDefault("customer.savedsuccess", "Cliente guardado correctamente"));
                this.Close();
            }
        }

        private void FrmRegisterCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            MultiLang.UnscribeChangeLangEvent(Translate);
        }

        private void FrmRegisterCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmRegisterCustomer_Shown(object sender, EventArgs e)
        {
            txtTaxpayerid.DataBindings.Add("Text", this.customer, "TaxPayerId");
            txtName.DataBindings.Add("Text", this.customer, "Name");
            txtLastname.DataBindings.Add("Text", this.customer, "LastName");
            txtMail.DataBindings.Add("Text", this.customer, "Mail");
            txtPhone.DataBindings.Add("Text", this.customer, "Phone");
            txtZipcode.DataBindings.Add("Text", this.customer, "ZipCode");
            txtAddress.DataBindings.Add("Text", this.customer, "Address");
        }
    }
}
