using System;
using System.Collections.Generic;
using System.ComponentModel;
using SistemaGestorEventos.BE;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Services
{
    public partial class ServiceComponent : UserControl
    {
        private Service service;
        private bool isEdit = false;
        public static ServiceComponent CreateNew()
        {
            return CreateFrom(new Service());
        }

        public static ServiceComponent CreateFrom(Service service, bool RO = false)
        {
            var form = new ServiceComponent();
            form.service = service;

            form.txtId.DataBindings.Add("Text", service, "Id");
            if (service.Id != null)
            {
                form.txtId.ReadOnly = true;
                form.isEdit = true;

            }

            form.txtName.DataBindings.Add("Text", service, "Name");
            form.txtPrice.DataBindings.Add("Text", service, "ProviderPrice");
            form.txtFee.DataBindings.Add("Text", service, "Fee");
            form.cbxStatus.DataBindings.Add("Checked", service, "Status");

            form.txtPrice.ReadOnly = RO;
            form.txtFee.ReadOnly = RO;
            form.txtName.ReadOnly = RO;

            return form;
        }
        public ServiceComponent()
        {
            InitializeComponent();
            service = new Service();
        }

        private void ServiceComponent_Load(object sender, EventArgs e)
        {
            
        }

        private void ServiceComponent_Load_1(object sender, EventArgs e)
        {

        }
    }
}
