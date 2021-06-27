using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Lugar
    {
        public string Nombre { get; set; }

        public string Direccion { get; set; }
        public List<string> Politicas { get; set; }

        public List<Espacio> Espcacios { get; set; }


    }
}
