using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public  class EventsBLL
    {

        private static readonly EventsBLL instance = new EventsBLL();

        private EventDAL eventDAL = EventDAL.Instance;

        private EventsBLL()
        {

        }

        public static EventsBLL Instance => instance;

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
            if (string.IsNullOrWhiteSpace(evt.Title)) errors.Add(MultiIdioma.TranslateOrDefault("event.error.title.requerided", "Ingrese un titulo"));
            if (evt.Id == null && evt.DateFrom < DateTime.Now)
                errors.Add(MultiIdioma.TranslateOrDefault("event.error.datefrom.requerided", "Ingrese una fecha desde mayor a la fecha actual"));
            if (evt.DateFrom != null && evt.DateTo != null && evt.DateTo <= evt.DateFrom)
            {
                errors.Add(MultiIdioma.TranslateOrDefault("event.error.dateto.exeded", "La fecha 'hasta' no puede ser menor que la fecha 'desde'"));
            }

            if (evt.MaxBudget <= 0)
            {
                errors.Add(MultiIdioma.TranslateOrDefault("event.error.budget.max.requerided", "Indique un presupuesto máximo"));
            }
            else if (evt.MinBudget > evt.MaxBudget)
            {
                errors.Add(MultiIdioma.TranslateOrDefault("event.error.budget.min.exeded", "El presupuesto minimo no puede ser superior al máximo"));
            }
            if (evt.EventType == null) errors.Add(MultiIdioma.TranslateOrDefault("event.error.eventtype.required", "Inidique la categoría del evento"));


            return errors;
        }
    }
}
