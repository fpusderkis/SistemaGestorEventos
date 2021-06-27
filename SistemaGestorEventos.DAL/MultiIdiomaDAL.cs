using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public class MultiIdiomaDAL : AbstractDAL, IMultiIdiomaDataSource
    {
        private static readonly MultiIdiomaDAL multiIdiomaDAL = new MultiIdiomaDAL();

        private MultiIdiomaDAL() { }

        public static MultiIdiomaDAL Instance => multiIdiomaDAL;

        public void AgregarTraduccion(string idioma,string key, string value)
        {
            this.InvokeProcedure("sp_Traducciones_Upsert", new Dictionary<string, object>() {
                { "@idioma", idioma},
                { "@clave", key},
                { "@valor", value}
            });
        }

        public Dictionary<string, string> CargarIdioma(string idioma)
        {
            using (var connection = this.GetSqlConnection())
            {
                SqlCommand sql = new SqlCommand("SELECT [clave],[valor] FROM Traducciones WHERE Idioma like @idioma; ");
                sql.Connection = connection;

                sql.Parameters.Add(new SqlParameter("@idioma", idioma));
                connection.Open();
                var reader = sql.ExecuteReader();

                Dictionary<string, string> traducciones = new Dictionary<string, string>();

                while (reader.Read())
                {
                    traducciones.Add(reader["clave"].ToString(), reader["valor"].ToString()); 
                }

                return traducciones;
            }
        }
    }
}
