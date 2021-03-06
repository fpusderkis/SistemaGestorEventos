using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public abstract class AbstractDAL
    {
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "DESKTOP-VRDL6E3\\SQLEXPRESS";
            cs.InitialCatalog = "sgedb";
            return cs.ConnectionString;
        }

        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        protected SqlConnection GetSqlConnectionOpen()
        {
            var con = GetSqlConnection();
            con.Open();
            return con;
        }

        protected void InvokeProcedure(string name, IDictionary<string,object> parameters)
        {
            using (var con = this.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(name);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (string key in parameters.Keys) {
                        if (parameters[key] == null)
                        {
                            command.Parameters.AddWithValue(key, DBNull.Value);
                        } 
                        else
                        {
                            command.Parameters.AddWithValue(key, parameters[key]);
                        }
                    }
                }

                command.Connection = con;
                con.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
