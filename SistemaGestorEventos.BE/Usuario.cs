using SistemaGestorEventos.BE.Permisos;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;

namespace SistemaGestorEventos.BE
{
    public class Usuario : AbstractEntity, IUser<TipoPermiso>
    {
        public Usuario(string username, string password, string idioma)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Idioma = idioma ?? throw new ArgumentNullException(nameof(idioma));
            Permisos = new List<Componente>();
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Idioma { get; set; }

        public List<Componente> Permisos { get; set; }

        public bool TienePermiso(TipoPermiso permiso)
        {
            if(Permisos != null)
            foreach (var c in Permisos)
            {
                if (TienePermiso(permiso, c)) return true;
            }

            return false;
        }

        private bool TienePermiso(TipoPermiso permiso, Componente componente)
        {
            if (permiso.Equals(componente.Permiso))
            {
                return true;
            }
                    
            if (componente.Hijos != null)
            foreach (Componente hijo in componente.Hijos)
            {
                if (TienePermiso(permiso, hijo))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
