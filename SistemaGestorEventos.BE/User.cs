using SistemaGestorEventos.BE.Grants;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;

namespace SistemaGestorEventos.BE
{
    public class User : AbstractEntity, IUser
    {

        public User()
        {

        }

        public User(string username, string password, string idioma) : base()
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Language = idioma ?? throw new ArgumentNullException(nameof(idioma));
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Language { get; set; }

        // TODO: ¿¿BORRAR PERMISOS?? pasaron a la sesion.
        // Tener en cuenta que se usan en el componente que hace abmc de permisos de usuario. entrega 2.
        public List<AbstractComponent> Permisos { get; set; }
        // FIN TODO

        public int FailCount { get; set; } = 0;

        public DateTime LastLogin { get; set; }

        public bool Expired { get; set; } = false;

        public int CheckDigit { get; set; }


    }
}
