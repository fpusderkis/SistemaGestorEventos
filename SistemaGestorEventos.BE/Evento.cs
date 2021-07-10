using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Evento : AbstractEntity
    {
        public String Titulo { get; set; }

        public String Descripcion { get; set; }

        public Usuario Organizador { get; set; }

        public DateTime FechaYHora { get; set; }

        public Espacio Espacio { get; set; }

        List<Servicio> Servicios { get; set; }

        List<Participante> Participantes { get; set; }

        public string ComprobantePago { get; set; }

        public EstadoEvento Estado { get; set; }



    }
}
