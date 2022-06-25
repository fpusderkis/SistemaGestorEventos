using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.exceptions;
using SistemaGestorEventos.SharedServices.hash;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class UserBLL : AbstractBLL
    {
        private static UserBLL instance = new UserBLL();
        private static UserDAL userDAL = UserDAL.GetInstance();


        private UserBLL() { }

        public static UserBLL Instance => instance;

        public IList<User> GetAll()
        {
            return userDAL.GetAll();
        }

        public void SaveUserGrants(User usuario)
        {
            userDAL.SaveUserGrants(usuario);
            BitacoraSingleton.GetInstance.Log($"Se guardaron los permisos del usuario {usuario.Username}");
        }

        public User FindUser(string username)
        {
            User usuario = userDAL.FindByUsername(username);

            return usuario;
        }

        public void SaveUser(User user)
        {
            userDAL.SaveUser(user);
        }

        public void Register(User usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Username)) throw new ValidationException("Nombre de usuario requerido");
            if (string.IsNullOrWhiteSpace(usuario.Password)) throw new ValidationException("Password requerido");
            if (string.IsNullOrWhiteSpace(usuario.Mail)) throw new ValidationException("Email requerido");
            if (string.IsNullOrWhiteSpace(usuario.Phone)) throw new ValidationException("Teléfono requerido");


            var usuarioBD = FindUser(usuario.Username);

            if (usuarioBD != null)
            {
                throw new ValidationException("El nombre de usuario ya esta registrado");
            }

            usuario.Id = Guid.NewGuid();

            RecalculateUserIntegrity(usuario, usuario.Password);
            usuario.Expired = true;

            usuario.Language = "es_AR";

            SaveUser(usuario);
        }

        private User RecalculateUserIntegrity(User usuario, string password)
        {
            var passwordHash = Cypher.Hash(password, usuario.Id);
            usuario.Password = passwordHash;
            usuario.CheckDigit = CheckerDigit.Generate(usuario.Id, passwordHash);
            usuario.Expired = false;
            usuario.FailCount = 0;

            return usuario;
        }

        public void ResetPassword(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(password)) throw new ValidationException("Contraseña requerida");

            var user = FindUser(username);

            RecalculateUserIntegrity(user, password);
            user.Expired = true;

            SaveUser(user);
        }

        public void LockUser(string username)
        {
            var user = FindUser(username);
            user.FailCount = 10;

            SaveUser(user);
        }
    }
}
