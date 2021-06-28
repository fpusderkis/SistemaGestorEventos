using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class UsuarioBLL : AbstractBLL
    {
        private static UsuarioBLL instance = new UsuarioBLL();
        private static UsuarioDAL usuarioDAL = UsuarioDAL.GetInstance();


        private UsuarioBLL() { }

        public static UsuarioBLL Instance => instance;

        public IList<Usuario> GetAll()
        {
            return usuarioDAL.GetAll();
        }

        public void GuardarPermisos(Usuario usuario)
        {
            usuarioDAL.GuardarPermisos(usuario);
        }
    }
}
