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
