using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class AditionalService : AbstractIdEntity
    {
        public Int32 EventId { get; set; }

        public Int32? ServiceId
            { 
                get 
                {
                    return Service.Id;
                } 
                set 
                {
                    this.Service.Id = value;
                }

            }

        public Service Service { get; set; } = new Service();

        public decimal Quantity { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public AditionalServiceStatus Status { get; set; } = AditionalServiceStatus.PENDING;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
