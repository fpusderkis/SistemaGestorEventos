using SistemaGestorEventos.BE;
using SistemaGestorEventos.SharedServices.Multiidioma;
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

        public EventForm(Event editable)
        {
            this.editable = editable;
            InitializeComponent();
            Translate();
            
            MultiIdioma.SuscribeCambioDeIdiomaEvent(Translate);
           

            if (this.editable.Id == null)
            {
                this.editable.DateFrom = DateTime.Now;
                this.editable.DateTo = DateTime.Now.AddHours(4);
            }

            txtEventTitle.DataBindings.Add("Text", this.editable, "Title");
            txtEventDescription.DataBindings.Add("Text", this.editable, "Description");
            txtBudgetMin.DataBindings.Add("Text", this.editable, "MinBudget");
            txtBudgetMax.DataBindings.Add("Text", this.editable, "MaxBudget");
            dtpFecha.DataBindings.Add("Text", this.editable, "DateFrom");
            dtpToDate.DataBindings.Add("Text", this.editable, "DateTo");
            cmbEventType.DataBindings.Add("SelectedItem", this.editable, "EventType");
            txtSpecialRequest.DataBindings.Add("Text", this.editable, "SpecialRequest");
            
            

        }
        private EventForm() : this(new Event())
        {
        }

        private void Translate()
        {
            WinformUtils.TraducirControl(this);
            var selected = this.cmbEventType.SelectedItem;

            this.cmbEventType.DataSource = Enum.GetValues(typeof(EventType)).Cast<EventType>()
              .Select(x => new { Value = x, Text = MultiIdioma.TranslateOrDefault("eventtype." + x.ToString(), Text.ToString()) })
              .ToList();

            this.cmbEventType.SelectedItem = selected;

        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            lblSelectedEventroomDetailValue.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

       
    }
}
