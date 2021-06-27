using SistemaGestorEventos.BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaGestorEventos.DAL
{
    public class UsuarioDAL : AbstractDAL
    {
        private static UsuarioDAL instancia = new UsuarioDAL();

        private UsuarioDAL() { }

        public static UsuarioDAL GetInstance() => instancia;

        public Usuario FindByUsername(string username)
        {
            using (var connection = this.GetSqlConnection())
            {
                /// TODO evaluar pasar a stored procedure
                /// 
                SqlCommand sql = new SqlCommand("SELECT username,password,idioma,id FROM Usuarios WHERE username like @username ;");
                sql.Connection = connection;

                sql.Parameters.Add(new SqlParameter("@username", username));
                connection.Open();
                var reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    var usuario = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    usuario.Id = reader.GetGuid(3);
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
        }

        public void GuardarPermisos(Usuario usuario)
        {
            using (var connection = this.GetSqlConnection())
            {
                var cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                
                cmd.CommandText = $@"delete from usuarios_permisos where id_usuario=@id;";
                cmd.Parameters.Add(new SqlParameter("id", usuario.Id));
                cmd.ExecuteNonQuery();

                foreach (var item in usuario.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = $@"insert into usuarios_permisos (id_usuario,id_permiso) values (@id_usuario,@id_permiso) "; ;
                    cmd.Parameters.Add(new SqlParameter("id_usuario", usuario.Id));
                    cmd.Parameters.Add(new SqlParameter("id_permiso", item.Id));

                    cmd.ExecuteNonQuery();
                }

            }
        }

        public IList<Usuario> GetAll()
        {
            using (var connection = this.GetSqlConnection())
            {
                /// TODO evaluar pasar a stored procedure
                /// 
                SqlCommand sql = new SqlCommand("SELECT username,password,idioma,id FROM Usuarios;");
                sql.Connection = connection;
                connection.Open();
                var reader = sql.ExecuteReader();
                var lista = new List<Usuario>();
                while (reader.Read())
                {
                    var usuario = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    usuario.Id = reader.GetGuid(3);
                    lista.Add(usuario);
                }
                reader.Close();

                return lista;
            }
        }

        public void Create(Usuario user)
        {
            using (var con = this.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("sp_Usuario_Crear");

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@idioma", user.Idioma);
                command.Parameters.AddWithValue("@id", user.Id);


                command.Connection = con;
                con.Open();
                command.ExecuteNonQuery();

            }
        }
    }
}
