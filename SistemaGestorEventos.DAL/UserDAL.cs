using SistemaGestorEventos.BE;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaGestorEventos.DAL
{
    public class UserDAL : AbstractDAL
    {
        private static UserDAL instancia = new UserDAL();

        private UserDAL() { }

        public static UserDAL GetInstance() => instancia;

        public User FindByUsername(string username)
        {
            using (var connection = this.GetSqlConnection())
            {
                connection.Open();

                var db = new Database(connection);
                var users = db.AddParameter("@username", username)
                    .ExecuteQuery<User>("SELECT * FROM Usuarios WHERE username like @username ;");

                return users.Count > 0 ? users[0] : null;
                
            }
        }

        public void GuardarPermisos(User usuario)
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

        public IList<User> GetAll()
        {
            using (var connection = this.GetSqlConnection())
            {
                /// TODO evaluar pasar a stored procedure
                /// 
                SqlCommand sql = new SqlCommand("SELECT username,password,idioma,id FROM Usuarios;");
                sql.Connection = connection;
                connection.Open();
                var reader = sql.ExecuteReader();
                var lista = new List<User>();
                while (reader.Read())
                {
                    var usuario = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    usuario.Id = reader.GetGuid(3);
                    lista.Add(usuario);
                }
                reader.Close();

                return lista;
            }
        }

        public void Create(User user)
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


        public void SaveUser(User user)
        {
            using (var con = this.GetSqlConnection())
            {
                con.Open();
                new Database(con)
                    
                    .AddParameter("@Username", user.Username)
                    .AddParameter("@Password", user.Password)
                    .AddParameter("@Id", user.Id)
                    .AddParameter("@LastLogin", user.LastLogin)
                    .AddParameter("@FailCount", user.FailCount)
                    .AddParameter("@Idioma", user.Idioma)
                    .AddParameter("@expired", user.Expired)
                    .AddParameter("@checkdigit", user.CheckDigit)


                    .ExecuteNonQuery("sp_Usuario_Upsert", true);
                    
            }
        }

        
    }
}
