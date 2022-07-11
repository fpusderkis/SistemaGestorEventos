using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Event : AbstractIdEntity
    {
        public Event()
        {
        }
        public String Title { get; set; }

        public Customer Customer { get; set; }

        public String Description { get; set; }
        public String SpecialRequest { get; set; }

        public Decimal MinBudget { get; set; }
        public Decimal MaxBudget { get; set; }

        public User CreatedBy { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public EventRoom EventRoom { get; set; }

        public EventType EventType { get; set; }

        public List<Servicio> AditionalServices { get; set; }


        public int GuessQuantity { get; set; }

        public EventStatus Status { get; set; }



    }
}
