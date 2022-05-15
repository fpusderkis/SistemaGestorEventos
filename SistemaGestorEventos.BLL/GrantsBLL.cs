using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Grants;
using SistemaGestorEventos.DAL.Permisos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class GrantsBLL : AbstractBLL
    {

        private static readonly GrantsBLL instance = new GrantsBLL();

        private GrantsBLL()
        {

        }

        public static GrantsBLL Instance => instance;

        private GrantsDAL permisosDAL = GrantsDAL.Instance;



        public bool Existe(AbstractComponent c, Guid id)
        {
            bool existe = false;

            if (c.Id.Equals(id))
                existe = true;
            else

                foreach (var item in c.Childs)
                {

                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;

        }


        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(GrantType));
        }


        public AbstractComponent GuardarComponente(AbstractComponent p, bool esfamilia)
        {
            return permisosDAL.GuardarComponente(p, esfamilia);
        }


        public void GuardarFamilia(Family c)
        {
            permisosDAL.GuardarFamilia(c);
        }

        public IList<Grant> GetAllPatentes()
        {
            return permisosDAL.GetAllPatentes();
        }

        public IList<Family> GetAllFamilias()
        {
            return permisosDAL.GetAllFamilias();
        }

        public IList<AbstractComponent> GetAll(string familia)
        {
            return permisosDAL.GetAll(familia);

        }

        public List<AbstractComponent> GetAllUserComponents(User user) => permisosDAL.GetAllUserComponents(user);

        public ISet<T> FindAllPermissions<T>(User u) where T : class
        {
            List<AbstractComponent> componentes = GetAllUserComponents(u);

            ISet<T> permissions = new HashSet<T>();
            
            foreach(var component in componentes)
            {
                FillAllPermissions(component, permissions);
            }

            return permissions;
        }

        private void FillAllPermissions<T>(AbstractComponent component, ISet<T> permissions) where T : class
        {

            if (component.GrantType != null)
            {    
                permissions.Add(component.GrantType as T);
            } else {
                foreach (var c in component.Childs)
                {
                    FillAllPermissions(c,permissions);
                }
            }
        }

        public void FillFamilyComponents(Family familia)
        {
            permisosDAL.FillFamilyComponents(familia);
        }

    }
}
