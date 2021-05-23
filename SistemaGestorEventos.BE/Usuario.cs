using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Usuario : AbstractEntity, IUser
    {
        public Usuario(string username, string password, string idioma)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Idioma = idioma ?? throw new ArgumentNullException(nameof(idioma));
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Idioma { get; set; }
    }
}
