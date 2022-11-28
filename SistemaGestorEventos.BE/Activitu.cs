using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Activity : AbstractIdEntity
    {
        public int ActivityOrder { get; set; }

        public string Description { get; set; }

        public Boolean Enabled { get; set; } = true;

    }
}
