using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Grants;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SistemaGestorEventos.DAL.Permisos
{
    public class GrantsDAL : AbstractDAL
    {

        private GrantsDAL() { }

        private static readonly GrantsDAL instance = new GrantsDAL();

        public static GrantsDAL Instance => instance;

        public AbstractComponent SaveComponent(AbstractComponent p, bool isFamily)
        {

            using (var connection = this.GetSqlConnection())
            {
                var db = new Database(connection);

                var sql = $@"insert into permiso (id,nombre,permiso) values (@id,@nombre,@permiso);";

                db.AddParameter("@nombre", p.Name)
                    .AddParameter("@id", p.Id)
                    ;



                if (isFamily)
                    db.AddParameter("@permiso", DBNull.Value);
                else
                    db.AddParameter("@permiso", p.GrantType.ToString());

                connection.Open();
                db.ExecuteNonQuery(sql);
                return p;
            }

        }


        public IList<Grant> GetAllGrants()
        {
            using (var connection = this.GetSqlConnection())
            {
                connection.Open();
                var cmd = new SqlCommand();
                cmd.Connection = connection;

                var sql = $@"select * from permiso p where p.permiso is not null;";

                cmd.CommandText = sql;

                var reader = cmd.ExecuteReader();

                var lista = new List<Grant>();

                while (reader.Read())
                {
                    var id = reader.GetGuid(reader.GetOrdinal("id"));
                    var nombre = reader.GetString(reader.GetOrdinal("nombre"));
                    var permiso = reader.GetString(reader.GetOrdinal("permiso"));


                    Grant c = new Grant();

                    c.Id = id;
                    c.Name = nombre;
                    c.GrantType = (GrantType)Enum.Parse(typeof(GrantType), permiso);
                    lista.Add(c);

                }
                reader.Close();

                return lista;

            }
        }

        public void AddRelatedComponent(Guid parentId, Guid childId)
        {
            using (var connection = this.GetSqlConnection())
            {
                connection.Open();
                var db = new Database(connection);

                var sql = "INSERT INTO [permiso_permiso] ([id_permiso_padre],[id_permiso_hijo]) VALUES (@id_permiso_padre, @id_permiso_hijo)";

                db.AddParameter("@id_permiso_padre",parentId)
                    .AddParameter("@id_permiso_hijo",childId)
                    .ExecuteNonQuery(sql);

            }
        }

        public void DeleteRelatedComponent(Guid parentId, Guid childId)
        {
            using (var connection = this.GetSqlConnection())
            {
                connection.Open();
                var db = new Database(connection);

                var sql = "DELETE FROM [permiso_permiso] WHERE [id_permiso_padre] = @id_permiso_padre AND [id_permiso_hijo] = @id_permiso_hijo";

                db.AddParameter("@id_permiso_padre", parentId)
                    .AddParameter("@id_permiso_hijo", childId)
                    .ExecuteNonQuery(sql);

            }
        }
        public List<Family> GetAllFamilias()
        {

            using (var connection = this.GetSqlConnection())
            {
                var cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();

                var sql = $@"select * from permiso p where p.permiso is  null;";

                cmd.CommandText = sql;

                var reader = cmd.ExecuteReader();

                var lista = new List<Family>();

                while (reader.Read())
                {


                    var id = reader.GetGuid(reader.GetOrdinal("id"));
                    var nombre = reader.GetString(reader.GetOrdinal("nombre"));


                    Family c = new Family();

                    c.Id = id;
                    c.Name = nombre;
                    lista.Add(c);

                }
                reader.Close();


                return lista;
            }
        }

        /// <summary>
        /// Hace una busqueda recursiva para obtener todo el arbol de permisos para una familia.
        /// </summary>
        /// <param name="familia"></param>
        /// <returns></returns>
        public IList<AbstractComponent> GetAll(string familia)
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

                var lista = new List<AbstractComponent>();

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


                    AbstractComponent c;

                    //usamos este campo para identificar. Solo las patentes van a tener un permiso del sistema relacionado
                    if (string.IsNullOrEmpty(permiso))
                        c = new Family();

                    else
                        c = new Grant();

                    c.Id = id;
                    c.Name = nombre;
                    if (!string.IsNullOrEmpty(permiso))
                        c.GrantType = (GrantType)Enum.Parse(typeof(GrantType), permiso);

                    var padre = GetComponent(id_padre, lista);

                    if (padre == null)
                    {
                        lista.Add(c);
                    }
                    else
                    {
                        padre.AddChild(c);
                    }
                }
                reader.Close();
                return lista;
            }

        }





        private AbstractComponent GetComponent(Guid id, IList<AbstractComponent> lista)
        {

            AbstractComponent component = lista != null ? lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

            if (component == null && lista != null)
            {
                foreach (var c in lista)
                {

                    var l = GetComponent(id, c.Childs);
                    if (l != null && l.Id == id) return l;
                    else
                    if (l != null)
                        return GetComponent(id, l.Childs);

                }
            }

            return component;
        }

        public List<AbstractComponent> GetAllUserComponents(User usuario)
        {

            using (var cnn = this.GetSqlConnection())
            {
                cnn.Open();

                var cmd2 = new SqlCommand();
                cmd2.Connection = cnn;
                cmd2.CommandText = $@"select p.* from usuarios_permisos up inner join permiso p on up.id_permiso=p.id where id_usuario=@id;";
                cmd2.Parameters.AddWithValue("id", usuario.Id);

                var reader = cmd2.ExecuteReader();
                var componentes = new List<AbstractComponent>();
                while (reader.Read())
                {

                    var idp = reader.GetGuid(reader.GetOrdinal("id"));
                    var nombrep = reader.GetString(reader.GetOrdinal("nombre"));

                    var permisop = String.Empty;
                    if (reader["permiso"] != DBNull.Value)
                        permisop = reader.GetString(reader.GetOrdinal("permiso"));

                    AbstractComponent c1;
                    if (String.IsNullOrEmpty(permisop))
                    {
                        c1 = new Family();
                        c1.Id = idp;
                        c1.Name = nombrep;

                        var f = GetAll($"='{idp}'");

                        foreach (var familia in f)
                        {
                            c1.AddChild(familia);
                        }
                        componentes.Add(c1);
                    }
                    else
                    {
                        c1 = new Grant();
                        c1.Id = idp;
                        c1.Name = nombrep;
                        c1.GrantType = (GrantType)Enum.Parse(typeof(GrantType), permisop);
                        componentes.Add(c1);
                    }



                }
                reader.Close();
                return componentes;
            }

        }
        public void FillFamilyComponents(Family familia)
        {
            foreach (var item in GetAll($"='{familia.Id}'"))
            {
                familia.AddChild(item);
            }
        }
    }
}
