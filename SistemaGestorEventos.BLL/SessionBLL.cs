using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.hash;
using SistemaGestorEventos.SharedServices.Session;
using SistemaGestorEventos.SharedServices.exceptions;
using System;
using SistemaGestorEventos.SharedServices.bitacora;
using System.Collections.Generic;

namespace SistemaGestorEventos.BLL
{
    public class SessionBLL : AbstractBLL
    {

        private static readonly SessionBLL instance = new SessionBLL();

        private UserBLL userBLL = UserBLL.Instance;

        private readonly Bitacora LOG = BitacoraSingleton.GetInstance;

        public static SessionBLL GetInstance() => instance;

        private SessionBLL()
        {

        }

        private static readonly SessionHandler SESSION = SessionHandler.GetInstance;

        private readonly UserDAL usuarioDAL = UserDAL.GetInstance();

        

        public User Login(string username, string password) 
        {
            var user = userBLL.FindUser(username);

            if (user == null)
            {
                throw new SistemaGestorEventos.BLL.Exceptions.BusinessException("login.invaliduserpass", "Usuario y/o clave invalida");
            }
            
            if (user.FailCount > 2)
            {
                LOG.Log(user.Id, "Usuario bloqueado");
                throw new SistemaGestorEventos.BLL.Exceptions.BusinessException("login.lockeduser", "Usuario bloqueado");
            }

            var pass = Cypher.Hash(password, user.Id);

            if (user.Password != pass)
            {
                user.FailCount ++;
                LOG.Log(user.Id, $"Password invalida. Intento: ${user.FailCount}");
                userBLL.SaveUser(user);
                throw new SistemaGestorEventos.BLL.Exceptions.BusinessException("login.invaliduserpass", "Usuario y/o clave invalida");
            }

            var digit = CheckerDigit.Generate(user.Id, pass);

            if (digit != user.CheckDigit)
            {
                LOG.Log(user.Id, "Digito verificador invalido");
                throw new SistemaGestorEventos.BLL.Exceptions.BusinessException("login.invaliddigit", "Registro de inicio de sesión corrupto,\n contacte al administrador");
            }



            if (user.Expired == true)
            {
                LOG.Log(user.Id, "Password expirado");
                throw new SistemaGestorEventos.BLL.Exceptions.PasswordExpiredException();
            }

            user.LastLogin = DateTime.Now;
            user.FailCount = 0;

            userBLL.SaveUser(user);

            ISet<object> grants = GrantsBLL.Instance.FindAllPermissions(user);

            SESSION.Login(user, grants);

            return user;
        }

        public void Logout()
        {
            SESSION.Logout();
        }
    }
}
