using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
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

        public void GuardarPermisos(User usuario)
        {
            userDAL.GuardarPermisos(usuario);
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
    }
}
