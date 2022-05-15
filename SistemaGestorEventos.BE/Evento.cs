using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Evento : AbstractEntity
    {
        public Evento()
        {
            Participantes = new List<Participante>();
        }
        public String Titulo { get; set; }

        public String Descripcion { get; set; }

        public User Organizador { get; set; }

        public DateTime FechaYHora { get; set; }

        public Lugar Lugar { get; set; }

        public List<Servicio> Servicios { get; set; }

        public List<Participante> Participantes { get; set; }

        public int CantidadParticipantes { get; set; }

        public string ComprobantePago { get; set; }

        public EstadoEvento Estado { get; set; }



    }
}
