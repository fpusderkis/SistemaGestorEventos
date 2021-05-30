using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.hash;
using SistemaGestorEventos.SharedServices.Session;
using SistemaGestorEventos.SharedServices.exceptions;
using System;

namespace SistemaGestorEventos.BLL
{
    public class SessionBLL : AbstractBLL
    {

        private static readonly SessionBLL instance = new SessionBLL();

        public static SessionBLL GetInstance() => instance;

        private SessionBLL()
        {

        }

        private static readonly SessionHandler SESSION = SessionHandler.GetInstance;

        private readonly UsuarioDAL usuarioDAL = UsuarioDAL.GetInstance();

        

        public Usuario Login(string username, string password) 
        {
            var usuario = usuarioDAL.FindByUsername(username);
            
            if (usuario != null)
            {
                var pass = Encriptador.Hash(password);
                if (usuario.Password == pass)
                {
                    SessionLogin(usuario);
                    return usuario;
                }
            }

            return null;
        }

        private void SessionLogin(Usuario usuario)
        {
            SESSION.Login(usuario);
        }

        public void Register(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Username)) throw new ValidationException("Nombre de usuario invalido");
            if (string.IsNullOrWhiteSpace(usuario.Password)) throw new ValidationException("Password invalido");
            if (string.IsNullOrWhiteSpace(usuario.Idioma)) throw new ValidationException("Idioma invalido");

            var usuarioBD = usuarioDAL.FindByUsername(usuario.Username);

            if (usuarioBD != null)
            {
                throw new ValidationException("El nombre de usuario ya esta registrado");
            }

            usuario.Id = Guid.NewGuid();
            usuario.Password = Encriptador.Hash(usuario.Password);
            usuarioDAL.Create(usuario);
            SessionLogin(usuario);
        }

        public void Logout()
        {
            SESSION.Logout();
        }
    }
}
