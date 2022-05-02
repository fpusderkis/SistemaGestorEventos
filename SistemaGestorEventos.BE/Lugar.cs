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

        public int CapacidadMaxima { get; set; }

        public double Precio { get; set; }

        public TipoLugar Tipo { get; set; }

        public Categoria Categoria { get; set; }


    }
}
