using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Activity : AbstractIdEntity
    {
        public int Order { get; set; }

        public string description { get; set; }

    }
}
