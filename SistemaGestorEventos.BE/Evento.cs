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

        public Espacio Espacio { get; set; }

        List<Servicio> Servicios { get; set; }

        List<Usuario> Participantes { get; set; }

    }
}
