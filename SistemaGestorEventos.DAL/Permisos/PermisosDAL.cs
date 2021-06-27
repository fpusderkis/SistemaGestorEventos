using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Permisos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SistemaGestorEventos.DAL.Permisos
{
    public class PermisosDAL : AbstractDAL
    {

        private PermisosDAL() { }

        private static readonly PermisosDAL instance = new PermisosDAL();

        public static PermisosDAL Instance => instance;

        public Componente GuardarComponente(Componente p, bool esfamilia)
        {
            using (var connection = this.GetSqlConnection())
            {
                
                var cmd = new SqlCommand();
                cmd.Connection = connection;

                var sql = $@"insert into permiso (id,nombre,permiso) values (@id,@nombre,@permiso); ";

                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("nombre", p.Nombre));
                cmd.Parameters.Add(new SqlParameter("id", p.Id));



                if (esfamilia)
                    cmd.Parameters.Add(new SqlParameter("permiso", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("permiso", p.Permiso.ToString()));

                connection.Open();
                cmd.ExecuteNonQuery();
                
                return p;
            }

        }


        public void GuardarFamilia(Familia c)
        {

            using (var connection = this.GetSqlConnection())
            {
                var cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();

                var sql = $@"delete from permiso_permiso where id_permiso_padre=@id;";

                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("id", c.Id));
                cmd.ExecuteNonQuery();

                foreach (var item in c.Hijos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = connection;


                    sql = $@"insert into permiso_permiso (id_permiso_padre,id_permiso_hijo) values (@id_permiso_padre,@id_permiso_hijo) ";

                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new SqlParameter("id_permiso_padre", c.Id));
                    cmd.Parameters.Add(new SqlParameter("id_permiso_hijo", item.Id));

                    cmd.ExecuteNonQuery();
                }

            }
            
        }

        public IList<Patente> GetAllPatentes()
        {
            using (var connection = this.GetSqlConnection())
            {
                connection.Open();
                var cmd = new SqlCommand();
                cmd.Connection = connection;

                var sql = $@"select * from permiso p where p.permiso is not null;";

                cmd.CommandText = sql;

                var reader = cmd.ExecuteReader();

                var lista = new List<Patente>();

                while (reader.Read())
                {
                    var id = reader.GetGuid(reader.GetOrdinal("id"));
                    var nombre = reader.GetString(reader.GetOrdinal("nombre"));
                    var permiso = reader.GetString(reader.GetOrdinal("permiso"));


                    Patente c = new Patente();

                    c.Id = id;
                    c.Nombre = nombre;
                    c.Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permiso);
                    lista.Add(c);

                }
                reader.Close();

                return lista;

            }
        }

        public List<Familia> GetAllFamilias()
        {

            using (var connection = this.GetSqlConnection())
            {
                var cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();

                var sql = $@"select * from permiso p where p.permiso is  null;";

                cmd.CommandText = sql;

                var reader = cmd.ExecuteReader();

                var lista = new List<Familia>();

                while (reader.Read())
                {


                    var id = reader.GetGuid(reader.GetOrdinal("id"));
                    var nombre = reader.GetString(reader.GetOrdinal("nombre"));


                    Familia c = new Familia();

                    c.Id = id;
                    c.Nombre = nombre;
                    lista.Add(c);

                }
                reader.Close();


                return lista;
            }
        }
        public IList<Componente> GetAll(string familia)
        {
            var where = "is NULL";

            if (!String.IsNullOrEmpty(familia))
            {
                where = familia;
            }

            
            var sql = $@"with recursivo as (
                        select sp2.id_permiso_padre, sp2.id_permiso_hijo  from permiso_permiso SP2
                        where sp2.id_permiso_padre {where}
                        UNION ALL 
                        select sp.id_permiso_padre, sp.id_permiso_hijo from permiso_permiso sp 
                        inner join recursivo r on r.id_permiso_hijo= sp.id_permiso_padre
                        )
                        select r.id_permiso_padre,r.id_permiso_hijo,p.id,p.nombre, p.permiso
                        from recursivo r 
                        inner join permiso p on r.id_permiso_hijo = p.id 
						
                        ";
            using (var connection = this.GetSqlConnection())
            {

                var cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql;
                connection.Open();

                var reader = cmd.ExecuteReader();

                var lista = new List<Componente>();

                while (reader.Read())
                {
                    Guid id_padre = Guid.Empty;
                    if (reader["id_permiso_padre"] != DBNull.Value)
                    {
                        id_padre = reader.GetGuid(reader.GetOrdinal("id_permiso_padre"));
                    }

                    var id = reader.GetGuid(reader.GetOrdinal("id"));
                    var nombre = reader.GetString(reader.GetOrdinal("nombre"));

                    var permiso = string.Empty;
                    if (reader["permiso"] != DBNull.Value)
                        permiso = reader.GetString(reader.GetOrdinal("permiso"));


                    Componente c;

                    //usamos este campo para identificar. Solo las patentes van a tener un permiso del sistema relacionado
                    if (string.IsNullOrEmpty(permiso))
                        c = new Familia();

                    else
                        c = new Patente();

                    c.Id = id;
                    c.Nombre = nombre;
                    if (!string.IsNullOrEmpty(permiso))
                        c.Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permiso);

                    var padre = GetComponent(id_padre, lista);

                    if (padre == null)
                    {
                        lista.Add(c);
                    }
                    else
                    {
                        padre.AgregarHijo(c);
                    }



                }
                reader.Close();
                return lista;
            }

        }





        private Componente GetComponent(Guid id, IList<Componente> lista)
        {

            Componente component = lista != null ? lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

            if (component == null && lista != null)
            {
                foreach (var c in lista)
                {

                    var l = GetComponent(id, c.Hijos);
                    if (l != null && l.Id == id) return l;
                    else
                    if (l != null)
                        return GetComponent(id, l.Hijos);

                }
            }

            return component;
        }

        public void FillUserComponents(Usuario u)
        {

            using (var cnn = this.GetSqlConnection())
            {
                cnn.Open();

                var cmd2 = new SqlCommand();
                cmd2.Connection = cnn;
                cmd2.CommandText = $@"select p.* from usuarios_permisos up inner join permiso p on up.id_permiso=p.id where id_usuario=@id;";
                cmd2.Parameters.AddWithValue("id", u.Id);

                var reader = cmd2.ExecuteReader();
                u.Permisos.Clear();
                while (reader.Read())
                {

                    var idp = reader.GetGuid(reader.GetOrdinal("id"));
                    var nombrep = reader.GetString(reader.GetOrdinal("nombre"));

                    var permisop = String.Empty;
                    if (reader["permiso"] != DBNull.Value)
                        permisop = reader.GetString(reader.GetOrdinal("permiso"));

                    Componente c1;
                    if (String.IsNullOrEmpty(permisop))
                    {
                        c1 = new Familia();
                        c1.Id = idp;
                        c1.Nombre = nombrep;

                        var f = GetAll("=" + idp);

                        foreach (var familia in f)
                        {
                            c1.AgregarHijo(familia);
                        }
                        u.Permisos.Add(c1);
                    }
                    else
                    {
                        c1 = new Patente();
                        c1.Id = idp;
                        c1.Nombre = nombrep;
                        c1.Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permisop);
                        u.Permisos.Add(c1);
                    }



                }
                reader.Close();
            }

        }
        public void FillFamilyComponents(Familia familia)
        {
            familia.VaciarHijos();
            foreach (var item in GetAll($"='{familia.Id}'"))
            {
                familia.AgregarHijo(item);
            }
        }
    }
}
