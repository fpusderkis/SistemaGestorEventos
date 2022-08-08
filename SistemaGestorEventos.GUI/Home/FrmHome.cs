using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Grants;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.i18n;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Home
{
    public partial class FrmHome : Form
    {

        private CustomerBLL customerBLL = CustomerBLL.Instance;
        private EventBLL eventBLL = EventBLL.Instance;
        private SessionHandler SESSION = SessionHandler.GetInstance;
        #region "event filter fields"
        public string Title { get; set; }
        public string Roomname { get; set; }

        public DateTime DateForm { get; set; } = DateTime.Now.AddMonths(-6).Date;
        public DateTime DateTo { get; set; } = DateTime.Now.AddMonths(+6).AddDays(1).Date.AddTicks(-1);
        
        public EventStatus? EventStatus { get; set; }

        #endregion
        public FrmHome()
        {
            InitializeComponent();

            this.dgvEvents.AutoGenerateColumns = false;
            this.dgvcEventFrom.Tag = "eventgrid.date.title";
            this.dgvcEventTitle.Tag = "eventgrid.title.title";
            this.dgvcStatus.Tag = "eventgrid.status.title";

            this.txtEventTitle.DataBindings.Add("Text", this, "Title");
            
            this.txtEventRoom.DataBindings.Add("Text", this, "Roomname");
            this.dtpFrom.DataBindings.Add("Value", this, "DateForm");
            this.dtpTo.DataBindings.Add("Value", this, "DateTo");
            this.cbxEventStatus.DataBindings.Add("SelectedItem", this, "EventStatus");
            
            MultiLang.SubscribeChangeLangEvent(Translate);
            Translate();

        }

        private void Translate()
        {
            WinformUtils.TraducirControl(this);
            if (dgvCustomers.Columns.Count > 3)
            {
                dgvCustomers.Columns[1].HeaderText = MultiLang.TranslateOrDefault("home.custommers.taxPayerId", "CUIL/CUIT");
                dgvCustomers.Columns[2].HeaderText = MultiLang.TranslateOrDefault("home.custommers.name", "Nombre");
                dgvCustomers.Columns[3].HeaderText = MultiLang.TranslateOrDefault("home.custommers.mail", "Mail");
            }

            var selected = this.cbxEventStatus.SelectedValue;

            ListItem<EventStatus?,string> item = new ListItem<EventStatus?, string>() { Key = null, Value = MultiLang.TranslateOrDefault("eventstatus.select", "Seleccione...")};
            this.cbxEventStatus.Items.Clear();
            this.cbxEventStatus.Items.Add(item);

            foreach (var x in Enum.GetValues(typeof(EventStatus)).Cast<EventStatus>().ToList())
            {
                cbxEventStatus.Items.Add(
                    new ListItem<EventStatus?, string>() { Key = x, Value = MultiLang.TranslateOrDefault("eventstatus." + x.ToString(), value: x.ToString()) }
                    );
            }
                

            this.cbxEventStatus.DisplayMember = "Value";
            this.cbxEventStatus.ValueMember = "Key";

            if (selected != null)
            {
                this.cbxEventStatus.SelectedItem = selected;
            } else
            {
                this.cbxEventStatus.SelectedItem = item;
            }

        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            
            if (dgvCustomers.SelectedRows.Count == 1)
            {
                String taxPayerId = (string)dgvCustomers.SelectedRows[0].Cells[1].Value;
                var customer = customerBLL.FindCustomer(taxPayerId, null, null)[0];

                var eventToEdit = new Event();
                eventToEdit.Customer = customer;
                eventToEdit.CreatedBy = (User) SessionHandler.GetInstance.User;
                var form = new Events.EventForm(eventToEdit);
                BitacoraSingleton.GetInstance.Log("Se abre evento NUEVO");
                form.ShowDialog();
            } else
            {
                MessageBox.Show(MultiLang.TranslateOrDefault("home.error.selectcustomer", "Seleccione un cliente"));
            }
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

        private void btnEventsSearch_Click(object sender, EventArgs e)
        {
            var selectedCustomer = (Customer)dgvCustomers.CurrentRow?.DataBoundItem;
            int? eventId = null;

            if (!string.IsNullOrEmpty(txtEventId.Text))
            {
                eventId = int.Parse(txtEventId.Text);
            }
            

            var events = this.eventBLL.FindEvents(
                eventId: eventId,
                customerId: selectedCustomer?.Id,
                title: Title,
                from: DateForm,
                to: DateTo,
                status: (EventStatus?)this.cbxEventStatus.SelectedValue
                );

            this.dgvEvents.DataSource = events;
        }

        private void txtEventId_TextChanged(object sender, EventArgs e)
        {
            txtEventId.Text = Regex.Replace(txtEventId.Text, "[^0-9]", "");
        }

        private void btnOpenEvent_Click(object sender, EventArgs e)
        {
            var selectedEvent = (Event)this.dgvEvents.CurrentRow?.DataBoundItem;

            if (selectedEvent != null)
            {
                Event editable = this.eventBLL.LoadFullEvent((int)selectedEvent.Id);
                editable.ModifiedBy = (User) SESSION.User;

                var eventForm = new Events.EventForm(editable);
                BitacoraSingleton.GetInstance.Log($"Se abre el evento {editable.Id}");
                eventForm.ShowDialog();

            }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            var canEditService = SessionHandler.GetInstance.HasGrant(GrantType.GestionarServicio);
            btnNewEvent.Enabled = canEditService;
            btnOpenEvent.Enabled = canEditService;
        }

        private void cbxEventStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbxCustomers_Enter(object sender, EventArgs e)
        {

        }
    }
}
