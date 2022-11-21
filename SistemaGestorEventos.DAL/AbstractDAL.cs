using SistemaGestorEventos.SharedServices.Persistance;
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

        protected int InvokeProcedure(string name) {
            return InvokeProcedure(name, null);
        }

        protected int InvokeProcedure(string name, IDictionary<string,object> parameters)
        {
            using (var con = this.GetSqlConnectionOpen())
            {
                var db = new Database(con);

                if (parameters != null)
                {
                    foreach (string key in parameters.Keys) {
                        db.AddParameter(key, parameters[key]);
                    }
                }

                return db.ExecuteNonQuery(name,true);
            }
        }

    }
}
