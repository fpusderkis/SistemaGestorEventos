using SistemaGestorEventos.BE;
using System;
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
                SqlCommand sql = new SqlCommand("SELECT username,password,idioma FROM Usuarios WHERE username like @username ;");
                sql.Connection = connection;

                sql.Parameters.Add(new SqlParameter("@username", username));
                connection.Open();
                var reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(1));
                }
                else
                {
                    return null;
                }
            }
        }

        public void Create(Usuario user)
        {
            using (var con = this.GetSqlConnection())
            {

                var sql = "INSERT INTO Usuarios (id,username,password,idioma) VALUES (@id,@username, @password,@idioma)";
                SqlCommand command = new SqlCommand();

                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@idioma", user.Idioma);
                command.Parameters.AddWithValue("@id", user.Id);


                command.Connection = con;
                command.CommandText = sql;
                con.Open();
                command.ExecuteNonQuery();

            }
        }
    }
}
