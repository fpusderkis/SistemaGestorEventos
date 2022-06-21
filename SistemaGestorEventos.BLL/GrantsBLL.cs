using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Grants;
using SistemaGestorEventos.DAL.Permisos;
using SistemaGestorEventos.SharedServices.exceptions;
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


        /// <summary>
        /// Revisa en funcion del ID si es o si contiene el componente dentro de la estructura del composite.
        /// </summary>
        /// <param name="c">componente</param>
        /// <param name="id">Id</param>
        /// <returns>true si existe</returns>
        public bool ExistsRelatedComponent(AbstractComponent parent, AbstractComponent child)
        {
            bool existe = false;

            if (parent.Id.Equals(child.Id))
                existe = true;
            else

                foreach (var item in parent.Childs)
                {

                    existe = ExistsRelatedComponent(item, child);
                    if (existe) return true;
                }

            return existe;

        }

        public bool AddToComponent(AbstractComponent parent, AbstractComponent child)
        {
            if (!ExistsRelatedComponent(parent, child))
            {
                permisosDAL.AddRelatedComponent(parent.Id, child.Id);
                return true;
            }

            return false;
        }

        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(GrantType));
        }



        public AbstractComponent SaveComponent(AbstractComponent p, bool esfamilia)
        {
            var components = permisosDAL.GetAll(p.Name);

            if (components != null && components.Count > 0)
            {
                throw new ValidationException("Ya existe un permiso con este nombre");
            }

            return permisosDAL.SaveComponent(p, esfamilia);
        }

        public AbstractComponent UpdateComponent(AbstractComponent component)
        {
            return permisosDAL.SaveComponent(component, component is Family);
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

        public ISet<object> FindAllPermissions(User u)
        {
            List<AbstractComponent> componentes = GetAllUserComponents(u);

            ISet<object> permissions = new HashSet<object>();
            
            foreach(var component in componentes)
            {
                FillAllPermissions(component, permissions);
            }

            return permissions;
        }

        private void FillAllPermissions(AbstractComponent component, ISet<object> permissions) 
        {

            if (component.GrantType != null)
            {    
                permissions.Add((GrantType)component.GrantType);
            } else {
                foreach (var c in component.Childs)
                {
                    FillAllPermissions(c,permissions);
                }
            }
        }

        public bool DeleteRelatedComponent(AbstractComponent parent, AbstractComponent child)
        {
            if (ExistsRelatedComponent(parent, child))
            {
                permisosDAL.DeleteRelatedComponent(parent.Id, child.Id);
                return true;
            }
            return false;
        }

        public void FillFamilyComponents(Family familia)
        {
            familia.Clear();
            permisosDAL.FillFamilyComponents(familia);
        }

    }
}
