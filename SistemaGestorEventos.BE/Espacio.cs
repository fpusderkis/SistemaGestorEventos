using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Espacio
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int CapacidadMaxima { get; set; }

        public double Precio { get; set; }

        public Lugar Lugar { get; set; }

    }
}
