using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Event : AbstractIdEntity
    {
        public Event()
        {
            this.Status = EventStatus.INITIALIZED;
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

        public List<Policy> EventRoomPolicies { get; set; } = new List<Policy>();
#nullable enable
        public string? EventRoomDetails { get; set; }
        
        public decimal? EventRoomPrice { get; set; }

        public EventType? EventType { get; set; }

#nullable disable
        public List<AditionalService> AditionalServices { get; set; }


        public Int32? GuessQuantity { get; set; }

        public EventStatus Status { get; set; }

        public decimal Price { get; set; }

        public decimal MinReservationPrice { get; set; }


    }
}
