using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public class ConfigurationDAL : AbstractDAL
    {
        public bool isConnectionStringConfigured()
        {
            return String.IsNullOrEmpty(GetConnectionString()); 
        }

        public string TestConnection(string connectionString)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = connectionString;
            String initialCatalog = builder.InitialCatalog;
            builder.InitialCatalog = "";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
            } catch (Exception e)
            {
                return e.Message;
            } finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return null;

        }

        public bool ExistCatalog(string conString)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = conString;
            String initialCatalog = builder.InitialCatalog;
            builder.InitialCatalog = "";

            SqlConnection connection = new SqlConnection(conString);

            try
            {
                connection.Open();
                var db = new SharedServices.Persistance.Database(connection);
                db.AddParameter("@catalog", initialCatalog);
                Int32 t = db.ExecuteScalar<Int32>("SELECT  count(1) FROM    information_schema.schemata WHERE CATALOG_NAME like @catalog");

                if (t > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return false;

        }

        public void SaveConnectionString(string conString)
        {
            DatabaseDatasource.Instance.UpdateRegistryConnectionString(conString);
        }

        public String CurrentConnectionString()
        {
            return GetConnectionString();
        }

        public string CreateDatabase(string conString)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = conString;
            String initialCatalog = builder.InitialCatalog;
            builder.InitialCatalog = "";

            Server server = null ;
            string calabaza = "";
            try
            {
                
                var sql = $"CREATE DATABASE {initialCatalog} \n GO \n use {initialCatalog} \n GO \n";
                var schemaFile = Properties.Resources.createSchema;
                var schemaCommands = schemaFile.Split("\nGO");
                var con = new ServerConnection();
                con.ConnectionString = builder.ConnectionString + ";TrustServerCertificate = True";
                server = new Server(serverConnection: con);
                
                server.ConnectionContext.Connect();
                server.ConnectionContext.ExecuteNonQuery(sql);
                server.ConnectionContext.ExecuteNonQuery(schemaFile);


                server.ConnectionContext.Disconnect();

            } catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (server != null)
                {
                    server.ConnectionContext.Disconnect();
                }
            }

            return null;

        }
    }
}
