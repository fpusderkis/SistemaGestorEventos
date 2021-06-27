using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE.Permisos
{
    public class Patente : Componente
    {
        public override IList<Componente> Hijos
        {
            get
            {
                return new List<Componente>();
            }

        }

        public override void AgregarHijo(Componente c)
        {

        }

        public override void BorrarHijo(Componente c)
        {
        }

        public override void VaciarHijos()
        {

        }
    }
}
