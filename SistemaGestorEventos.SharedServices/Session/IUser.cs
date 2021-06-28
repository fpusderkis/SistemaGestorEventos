using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.Session
{
    public interface IUser<T>
    {
        public Guid Id { get; }
        public string Username { get; }
        public bool TienePermiso(T permiso);
    }
}
