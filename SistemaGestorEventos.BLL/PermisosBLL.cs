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

        public void FillUserComponents(Usuario u)
        {
            u.Permisos = permisosDAL.GetAllUserComponents(u);
        }

        public void FillFamilyComponents(Familia familia)
        {
            permisosDAL.FillFamilyComponents(familia);
        }

    }
}
