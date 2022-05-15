using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Permisos;
using SistemaGestorEventos.DAL.Permisos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class PermisosBLL : AbstractBLL
    {

        private static readonly PermisosBLL instance = new PermisosBLL();

        private PermisosBLL()
        {

        }

        public static PermisosBLL Instance => instance;

        private PermisosDAL permisosDAL = PermisosDAL.Instance;



        public bool Existe(Componente c, Guid id)
        {
            bool existe = false;

            if (c.Id.Equals(id))
                existe = true;
            else

                foreach (var item in c.Hijos)
                {

                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;

        }


        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(TipoPermiso));
        }


        public Componente GuardarComponente(Componente p, bool esfamilia)
        {
            return permisosDAL.GuardarComponente(p, esfamilia);
        }


        public void GuardarFamilia(Familia c)
        {
            permisosDAL.GuardarFamilia(c);
        }

        public IList<Patente> GetAllPatentes()
        {
            return permisosDAL.GetAllPatentes();
        }

        public IList<Familia> GetAllFamilias()
        {
            return permisosDAL.GetAllFamilias();
        }

        public IList<Componente> GetAll(string familia)
        {
            return permisosDAL.GetAll(familia);

        }

        public List<Componente> GetAllUserComponents(User user) => permisosDAL.GetAllUserComponents(user);

        public ISet<T> FindAllPermissions<T>(User u) where T : class
        {
            List<Componente> componentes = GetAllUserComponents(u);

            ISet<T> permissions = new HashSet<T>();
            
            foreach(var component in componentes)
            {
                FillAllPermissions(component, permissions);
            }

            return permissions;
        }

        private void FillAllPermissions<T>(Componente component, ISet<T> permissions) where T : class
        {

            if (component.Permiso != null)
            {    
                permissions.Add(component.Permiso as T);
            } else {
                foreach (var c in component.Hijos)
                {
                    FillAllPermissions(c,permissions);
                }
            }
        }

        public void FillFamilyComponents(Familia familia)
        {
            permisosDAL.FillFamilyComponents(familia);
        }

    }
}
