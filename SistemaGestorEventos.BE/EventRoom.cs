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

    }
}
