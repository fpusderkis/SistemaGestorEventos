using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public  class EventBLL
    {

        private static readonly EventBLL instance = new EventBLL();

        private EventDAL eventDAL = EventDAL.Instance;

        private EventBLL()
        {

        }

        public static EventBLL Instance => instance;

        public List<string> SaveEvent(Event evt)
        {
            var errors = ValidateEvent(evt);

            if (errors.Count > 0) return errors;

            eventDAL.SaveEvent(evt);
            

            return errors;
        }


        public List<string> ValidateEvent(Event evt)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrWhiteSpace(evt.Title)) errors.Add(MultiLang.TranslateOrDefault("event.error.title.requerided", "Ingrese un titulo"));
            if (evt.Id == null && evt.DateFrom < DateTime.Now)
                errors.Add(MultiLang.TranslateOrDefault("event.error.datefrom.requerided", "Ingrese una fecha desde mayor a la fecha actual"));
            if (evt.DateFrom != null && evt.DateTo != null && evt.DateTo <= evt.DateFrom)
            {
                errors.Add(MultiLang.TranslateOrDefault("event.error.dateto.exeded", "La fecha 'hasta' no puede ser menor que la fecha 'desde'"));
            }

            if (evt.MaxBudget <= 0)
            {
                errors.Add(MultiLang.TranslateOrDefault("event.error.budget.max.requerided", "Indique un presupuesto máximo"));
            }
            else if (evt.MinBudget > evt.MaxBudget)
            {
                errors.Add(MultiLang.TranslateOrDefault("event.error.budget.min.exeded", "El presupuesto minimo no puede ser superior al máximo"));
            }
            if (evt.EventType == null) errors.Add(MultiLang.TranslateOrDefault("event.error.eventtype.required", "Inidique la categoría del evento"));


            return errors;
        }

        public IList<Event> FindEvents(Int32? eventId, Int32? customerId, string title, DateTime? from, DateTime? to, EventStatus? status)
        {
            return eventDAL.FindEvents(eventId, customerId, title, from, to, status);
        }

        public Event LoadFullEvent(Int32 id)
        {
            Event evt = FindEvents(id, null, null, null, null, null)[0];

            return eventDAL.LoadFullEvent(evt);
        }
    }
}
