using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.i18n;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public  class EventBLL
    {

        private static readonly EventBLL instance = new EventBLL();

        private EventDAL eventDAL = EventDAL.Instance;
        private PaymentBLL paymentBLL = PaymentBLL.Instance;


        private EventBLL()
        {

        }

        public static EventBLL Instance => instance;

        public List<string> SaveEvent(Event evt)
        {
            var errors = ValidateEvent(evt);

            if (errors.Count > 0) return errors;

            if (evt.Id != null)
            {
                evt.ModifiedBy = (User) SessionHandler.GetInstance.User;
            } else
            {
                evt.CreatedBy = (User)SessionHandler.GetInstance.User;
            }
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

        private List<string> ValidateEventBudget(Event evt)
        {
            List<string> errors = ValidateEvent(evt);

            if (evt.EventRoom == null)
            {
                errors.Add(MultiLang.TranslateOrDefault("event.error.eventroom.required", "Debe seleccionar un lugar de realización"));
            }
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

        /// <summary>
        /// Cost of event (included fees)
        /// </summary>
        /// <param name="evt"></param>
        /// <returns></returns>
        public decimal CalculateCost(Event evt)
        {
            decimal cost = 0;
            if (evt.EventRoom != null)
            {
                cost += evt.EventRoom.Price;
            }
            evt.AditionalServices.ForEach(aditionalService =>
            {
                cost += aditionalService.Price * aditionalService.Quantity ;
            });


            return cost;
        }


        public decimal CalculateMinPendingAmount(Event evt)
        {
            
            return CalculateCost(evt) / 2; // 50%
            
        }

        public decimal CalculatePaidAmount(Event evt)
        {
            decimal paidAmount = 0;
            evt.Payments.ForEach(p => paidAmount += p.Amount);
            return paidAmount;
        }

        public List<string> GenerateBudget(Event evt)
        {
            List<string> errors = ValidateEventBudget(evt);
            if (errors.Count > 0) return errors;

            evt.Status = EventStatus.BUDGET;
            this.SaveEvent(evt);

            return errors;
        }

        public List<string> AddPayment(Event editable, Payment payment)
        {
            
            if (CalculateCost(editable) - CalculatePaidAmount(editable) - payment.Amount < 0)
            {
                var errors = new List<string>();
                errors.Add(MultiLang.TranslateOrDefault("event.payment.error.totalamountexceded", "El pago que intenta registrar excede el monto total del evento"));
                return errors;
            }
            payment.EventId = editable.Id;

            return paymentBLL.SavePayment(payment);
           
        }

        public List<string> Confirm(Event evt)
        {
            decimal paidAmount = CalculatePaidAmount(evt);
            decimal minPaidAmount = CalculateMinPendingAmount(evt);

            if (paidAmount < minPaidAmount)
            {
                var errors = new List<string>();
                errors.Add(MultiLang.TranslateOrDefault("event.payment.error.totalamountexceded", "El pago que intenta registrar excede el monto total del evento"));
                return errors;
            }

            evt.Status = EventStatus.CONFIRMED;
            return SaveEvent(evt);
        }
    }
}
