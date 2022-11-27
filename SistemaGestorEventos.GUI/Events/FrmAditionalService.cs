using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Windows.Forms;
using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.i18n;

namespace SistemaGestorEventos.GUI.Events
{
    public partial class FrmAditionalService : Form
    {

        private AditionalService aditionalService;

        public static FrmAditionalService CreateFromAditionalService(AditionalService aditionalService)
        {
            var form = new FrmAditionalService(aditionalService);
            return form;
        }

        private FrmAditionalService(AditionalService aditionalService)
        {
            InitializeComponent();
            this.aditionalService = aditionalService;
            this.txtServiceCost.Text = aditionalService.Cost.ToString();
            this.gbxServiceRO.Controls.Add(Services.ServiceComponent.CreateFrom(aditionalService.Service,true));

            this.txtServiceQty.DataBindings.Add("Text", this.aditionalService, "Quantity");
            this.txtServiceQty.ReadOnly = true;
            this.txtServiceCost.Text = this.aditionalService.Service.ProviderPrice.ToString();
            this.txtASPrice.DataBindings.Add("Text", this.aditionalService, "CalculedPrice");
            this.txtASPrice.ReadOnly = true;
            txtObs.DataBindings.Add("Text", this.aditionalService, "Description");



        }
        private FrmAditionalService()
        {
            InitializeComponent();
        }

        private void FrmAditionalService_Load(object sender, EventArgs e)
        {

        }

        private void txtServiceQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void CalculateTotals()
        {
            decimal value;
            if (!decimal.TryParse(this.txtServiceCost.Text,out value))
            {
                this.txtServiceCost.Text = this.aditionalService.Service.ProviderPrice.ToString();
                return;
            }
            
                
           lblTotalCost.Text = (this.aditionalService.Quantity * value).ToString();
        }

        private void txtASPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtServiceCost_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<string> errors = AditionalServicesBLL.Instance.Confirm(this.aditionalService, decimal.Parse(txtServiceCost.Text));

            if (errors.Count > 0)
            {
                WinformUtils
                   .ShowErrorList(MultiLang.TranslateOrDefault("event.as.manage.confirm.errortitle", "No se pudo confirmar el servicio"), errors);
            } else
            {
                MessageBox.Show(MultiLang.TranslateOrDefault("event.as.manage.confirm.ok", "Servicio confirmado"));
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AditionalServicesBLL.Instance.CancelProvider(this.aditionalService, decimal.Parse(txtServiceCost.Text));
            MessageBox.Show(MultiLang.TranslateOrDefault("event.as.manage.provider.cancel", "Servicio Cancelado"));
            this.Close();
        }
    }
}
