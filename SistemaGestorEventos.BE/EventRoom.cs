using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class EventRoom : AbstractIdEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Capacity { get; set; }

        public Decimal Price { get; set; }

        public Decimal BucketSize { get; set; }

        public Boolean Active { get; set; }

        public Decimal DVH { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }



    }
}
