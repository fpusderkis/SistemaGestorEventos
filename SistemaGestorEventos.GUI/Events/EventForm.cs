using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;
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

        private EventRoomBLL eventRoomsBLL = EventRoomBLL.Instance;
        private EventsBLL eventsBLL = EventsBLL.Instance;

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
            txtEventroomDetailsValue.DataBindings.Add("Text", this.editable, "EventRoomDetails");
            txtBudgetMin.DataBindings.Add("Text", this.editable, "MinBudget");
            txtBudgetMax.DataBindings.Add("Text", this.editable, "MaxBudget");
            dtpFecha.DataBindings.Add("Value", this.editable, "DateFrom");
            dtpToDate.DataBindings.Add("Value", this.editable, "DateTo");
            cmbEventType.DataBindings.Add("SelectedValue", this.editable, "EventType");
            txtSpecialRequest.DataBindings.Add("Text", this.editable, "SpecialRequest");
            
            

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
              new { Value = x, Text = MultiIdioma.TranslateOrDefault("eventtype." + x.ToString(), x.ToString()) })
              .ToList();

            if (selected != null)
            {
                this.cmbEventType.SelectedValue = selected;
            }

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
                WinformUtils.ShowErrorList(MultiIdioma.TranslateOrDefault("event.errortitle", "Deberá corregir los siguientes puntos"), errors);
            } else
            {
                MessageBox.Show(MultiIdioma.TranslateOrDefault("event.savedok", "Evento guardado con éxito"));
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
                    this.lblSelectedEventroomDetailValue.Text = $"{valor.Id} - {valor.Name} - $ {valor.Price} / {valor.BucketSize} Hs.";
                }
            }

        }
    }
}
