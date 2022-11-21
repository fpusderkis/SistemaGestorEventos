using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Log : AbstractIdEntity
    {
        public string Username { get; set; }

        public string Message { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
