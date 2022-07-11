using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Participante : AbstractGuidEntity
    {
        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }
    }
}
