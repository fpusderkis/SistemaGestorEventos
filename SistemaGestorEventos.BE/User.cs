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
            Idioma = idioma ?? throw new ArgumentNullException(nameof(idioma));
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Idioma { get; set; }

        public List<AbstractComponent> Permisos { get; set; }

        public int FailCount { get; set; } = 0;

        public DateTime LastLogin { get; set; }

        public bool Expired { get; set; } = false;

        public int CheckDigit { get; set; }


    }
}
