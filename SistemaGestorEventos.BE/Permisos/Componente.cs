using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE.Permisos
{
    public abstract class Componente : AbstractEntity
    {
        public string Nombre { get; set; }
        
        public abstract IList<Componente> Hijos { get; }
        public abstract void AgregarHijo(Componente c);

        public abstract void BorrarHijo(Componente c);

        public abstract void VaciarHijos();
        public TipoPermiso? Permiso { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
