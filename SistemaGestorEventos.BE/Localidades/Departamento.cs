using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE.Localidades
{
    public class Departamento : AbstractLocalidad
    {
        public Provincia Provincia { get; set; }
    }
}
