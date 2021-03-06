using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Events
{
    public partial class EventForm : Form
    {

        private Event editable;

        private EventRoomBLL eventRoomsBLL = EventRoomBLL.Instance;
        private AditionalServicesBLL aditionalServicesBLL = AditionalServicesBLL.Instance;
        private EventBLL eventsBLL = EventBLL.Instance;

        private BindingSource asBS;
        private BindingSource paymentsBS;


        public EventForm(Event editable)
        {
            this.editable = editable;
            InitializeComponent();
            Translate();
            
            MultiLang.SubscribeChangeLangEvent(Translate);
           

            if (this.editable.Id == null)
            {
                this.editable.DateFrom = DateTime.Now;
                this.editable.DateTo = DateTime.Now.AddHours(4);
            }

            txtEventTitle.DataBindings.Add("Text", this.editable, "Title");
            txtEventDescription.DataBindings.Add("Text", this.editable, "Description");
            txtEventroomDetailsValue.DataBindings.Add("Text", this.editable, "EventRoomDetails");
            txtBudgetMin.DataBindings.Add("Text", this.editable, "MinBudget");
            txtBudgetMax.DataBindings.Add("Text", this.editable, "MaxBudget");
            dtpFecha.DataBindings.Add("Value", this.editable, "DateFrom");
            dtpToDate.DataBindings.Add("Value", this.editable, "DateTo");
            cmbEventType.DataBindings.Add("SelectedValue", this.editable, "EventType");
            txtSpecialRequest.DataBindings.Add("Text", this.editable, "SpecialRequest");
            dgvAddedServices.AutoGenerateColumns = false;

            dgvSearchAS.AutoGenerateColumns = false;
            this.asBS = new BindingSource();
            this.asBS.DataSource = this.editable.AditionalServices;
            dgvAddedServices.DataSource = this.asBS;


            dgvPayments.AutoGenerateColumns = false;
            this.paymentsBS = new BindingSource();
            this.paymentsBS.DataSource = this.editable.Payments;
            dgvPayments.DataSource = this.paymentsBS;

            CalculateEventRoomLegend(this.editable);

        }       
        private EventForm() : this(new Event())
        {
        }

        private void Translate()
        {
            WinformUtils.TraducirControl(this);
            var selected = this.cmbEventType.SelectedValue;

            this.cmbEventType.DataSource = Enum.GetValues(typeof(EventType)).Cast<EventType>()
              .Select(x => 
              new { Value = x, Text = MultiLang.TranslateOrDefault("eventtype." + x.ToString(), x.ToString()) })
              .ToList();

            if (selected != null)
            {
                this.cmbEventType.SelectedValue = selected;
            }

            var selectedPaymentType = this.cbxNewPaymentType.SelectedValue;

            this.cbxNewPaymentType.DataSource = Enum.GetValues(typeof(PaymentType)).Cast<PaymentType>()
          .Select(x =>
          new { Value = x, Text = MultiLang.TranslateOrDefault("paymentType." + x.ToString(), x.ToString()) })
          .ToList();

            if (selectedPaymentType != null)
            {
                this.cbxNewPaymentType.SelectedValue = selectedPaymentType;
            }


            this.dgvASFilterCId.HeaderText = MultiLang.TranslateOrDefault("filter.aditionalservice.column.id", "Id");
            this.dgvASFilterCName.HeaderText = MultiLang.TranslateOrDefault("filter.aditionalservice.column.name", "Nombre");
            this.dgvASFilterCPrice.HeaderText = MultiLang.TranslateOrDefault("filter.aditionalservice.column.price", "Precio");

            this.dgvPaymentsCAmount.HeaderText = MultiLang.TranslateOrDefault("dgvpayments.column.amount", "Monto");
            this.dgvPaymentsCConciliationKey.HeaderText = MultiLang.TranslateOrDefault("dgvpayments.column.conciliationKey", "Clave de conciliación");
            this.dgvPaymentsCDate.HeaderText = MultiLang.TranslateOrDefault("dgvpayments.column.paymentdate", "Fecha");
            this.dgvPaymentsCId.HeaderText = MultiLang.TranslateOrDefault("dgvpayments.column.id", "Id");
            this.dgvPaymentsCType.HeaderText = MultiLang.TranslateOrDefault("dgvpayments.column.paymenttype", "Tipo");


        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            lblSelectedEventroomDetailValue.Text = "";
            CalculateEventRoomLegend(this.editable);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchEventroom_Click(object sender, EventArgs e)
        {
            Int32? id = null;
            if (!string.IsNullOrWhiteSpace(txtFilterEventroomId.Text) && txtFilterEventroomId.Text.All(char.IsNumber))
            {
                id = Int32.Parse(txtFilterEventroomId.Text);
            }
            IList<EventRoom> eventRooms = eventRoomsBLL.FindAvailiableEventrooms(id, txtFilterEventroomName.Text, this.editable.DateFrom, this.editable.DateTo);


            refreshDGVEventRooms(eventRooms);
        }

        private void refreshDGVEventRooms(IList<EventRoom> eventRooms)
        {
            this.dgvEventrooms.SuspendLayout();

            this.dgvEventrooms.DataSource = eventRooms;

            this.dgvEventrooms.ResumeLayout();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            var errors = eventsBLL.SaveEvent(this.editable);


            if (errors.Count > 0)
            {
                WinformUtils.ShowErrorList(MultiLang.TranslateOrDefault("event.errortitle", "Deberá corregir los siguientes puntos"), errors);
            } else
            {
                MessageBox.Show(MultiLang.TranslateOrDefault("event.savedok", "Evento guardado con éxito"));
            }

        }

        private void cmbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.editable.EventType = (EventType) this.cmbEventType.SelectedValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvEventrooms.CurrentRow != null)
            {
                var valor = (EventRoom) dgvEventrooms.CurrentRow.DataBoundItem;

                if (this.editable.EventRoom?.Id != valor.Id)
                {
                    this.editable.EventRoom = valor;
                    this.editable.EventRoomPrice = valor.Price; // calcular precio
                    CalculateEventRoomLegend(this.editable);
                }
            }

        }

        private void CalculateEventRoomLegend(Event evt)
        {
            if (evt.EventRoom != null)
            {
                CalculateEventAmounts();
                this.lblSelectedEventroomDetailValue.Text = $"{evt.EventRoom.Id} - {evt.EventRoom.Name} - $ {evt.EventRoomPrice}";
            }
        }

        private void btnSearchAS_Click(object sender, EventArgs e)
        {
            var services = aditionalServicesBLL.FindServicesByName(this.txtFilterASName.Text.Trim());
            this.dgvSearchAS.DataSource = services;
        }

        private void btnAddAS_Click(object sender, EventArgs e)
        {
            if (this.dgvSearchAS.SelectedRows.Count == 1)
            {
                var service = (Service)this.dgvSearchAS.CurrentRow.DataBoundItem;

                var aditionalService = new AditionalService();
                aditionalService.Service = service;
                aditionalService.Price = service.Price;
                aditionalService.Quantity = 1;
                this.editable.AditionalServices.Add(aditionalService);
                refreshDGVAddedServices();
                CalculateEventAmounts();
            }
        }

        private void refreshDGVAddedServices()
        {
            this.dgvAddedServices.SuspendLayout();
            this.dgvAddedServices.DataSource = null;
            this.dgvAddedServices.DataSource = this.editable.AditionalServices;
            this.dgvAddedServices.ResumeLayout();
        }

        private void dgvAddedServices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.editable.AditionalServices.Count == 0)
            {
                return;
            }
            AditionalService data = (AditionalService)dgvAddedServices.Rows[e.RowIndex].DataBoundItem;

            dgvAddedServices.Rows[e.RowIndex].Cells["dgvASCName"].Value = data.Service.Name;
            dgvAddedServices.Rows[e.RowIndex].Cells["dgvASCId"].Value = data.Service.Id;
            dgvAddedServices.Rows[e.RowIndex].Cells["dgvASCPrice"].Value = data.Service.Price * data.Quantity;
        }

        private void dgvAddedServices_SelectionChanged(object sender, EventArgs e)
        {

            txtASDetails.DataBindings.Clear();
            txtASQty.DataBindings.Clear();

            if (dgvAddedServices.SelectedRows.Count > 0)
            {
                var aditionalService = (AditionalService) dgvAddedServices.CurrentRow.DataBoundItem;

                txtASDetails.DataBindings.Add("Text", aditionalService, "Description");
                txtASQty.DataBindings.Add("Text", aditionalService, "Quantity");
                CalculateEventAmounts();
            }
        }

        private void CalculateEventAmounts()
        {
            this.lblPaidValue.Text = "$ " + this.eventsBLL.CalculatePaidAmount(this.editable);
            this.lblPendingPayValue.Text = "$ " + this.eventsBLL.CalculateMinPendingAmount(this.editable);
            this.lblTotalValue.Text = "$" + this.eventsBLL.CalculateCost(this.editable);
            
        }

        private void txtASQty_ValueChanged(object sender, EventArgs e)
        {
            CalculateEventAmounts();
        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            var payment = new Payment();
            payment.Amount = txtNewPaymentAmount.Value;
            payment.Active = true;
            payment.ConciliationKey = txtConciliationKey.Text;
            payment.Type = (PaymentType) this.cbxNewPaymentType.SelectedValue;
            payment.PaymentDate = this.dtpNewPaymentDate.Value;
            this.editable.Payments.Add(payment);
            refreshDGVRegisterdPayments(this.editable.Payments);

        }


        private void refreshDGVRegisterdPayments(List<Payment> payments)
        { 

            this.dgvPayments.DataSource = null;
            this.dgvPayments.DataSource = this.editable.Payments.Where<Payment>(p => p.Active).ToList<Payment>();

        }

        private void dgvPayments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Payment data = (Payment)dgvPayments.Rows[e.RowIndex].DataBoundItem;

            dgvPayments.Rows[e.RowIndex].Cells["dgvPaymentsCId"].Value = data.Id;
            dgvPayments.Rows[e.RowIndex].Cells["dgvPaymentsCDate"].Value = data.PaymentDate;
            dgvPayments.Rows[e.RowIndex].Cells["dgvPaymentsCConciliationKey"].Value = data.ConciliationKey;
            dgvPayments.Rows[e.RowIndex].Cells["dgvPaymentsCAmount"].Value = data.Amount;
            
            var paymentType = MultiLang.TranslateOrDefault("paymentType." + data.Type, data.Type.ToString());
            dgvPayments.Rows[e.RowIndex].Cells["dgvPaymentsCType"].Value = paymentType;
        }

        private void txtNewPaymentAmount_ValueChanged(object sender, EventArgs e)
        {
            if (txtNewPaymentAmount.Value >= 1) btnAddNewPayment.Enabled = true;
            else btnAddNewPayment.Enabled = false;
        }

        private void dgvPayments_SelectionChanged(object sender, EventArgs e)
        {
            this.btnDeleteSelectedPayment.Enabled = true;
        }

        private void btnDeleteSelectedPayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show(
                    MultiLang.TranslateOrDefault("event.payment.delete.confirm", "Desea eliminar el pago seleccionado?"),
                    MultiLang.TranslateOrDefault("event.payment.delete.confirm.title", "Eliminar pago"),
                    MessageBoxButtons.YesNo);

                if (DialogResult.Yes == confirmResult)
                {
                    var payment = (Payment)dgvPayments.CurrentRow.DataBoundItem;
                    payment.Active = false;
                    refreshDGVRegisterdPayments(this.editable.Payments);
                }
            }
        }

        private void btnASRemove_Click(object sender, EventArgs e)
        {
            if (dgvAddedServices.CurrentRow != null)
            {
                var confirmResult = MessageBox.Show(
                    MultiLang.TranslateOrDefault("event.aditionalservice.delete.confirm", "Desea eliminar el servicio seleccionado?"),
                    MultiLang.TranslateOrDefault("event.aditionalservice.delete.confirm.title", "Eliminar pago"),
                    MessageBoxButtons.YesNo);

                if (DialogResult.Yes == confirmResult)
                {
                    this.editable.AditionalServices.Remove(
                        (AditionalService)dgvAddedServices.CurrentRow.DataBoundItem
                        );
                    refreshDGVAddedServices();
                }
            }
        }
    }
}
