using SistemaGestorEventos.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class ConfigurationBLL
    {
        private ConfigurationDAL configurationDAL = new ConfigurationDAL();

        public List<string> SaveConnectionString(string conString, bool create = true)
        {
            var errors = new List<string>();


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            try
            {
                builder.ConnectionString = conString;
                if (string.IsNullOrEmpty(builder.InitialCatalog)){
                    errors.Add("Indique el nombre de la base de datos con el parametro \"InitialCatalog=dbname\".");
                }
            } catch (ArgumentException ae)
            {
                errors.Add("Cadena de conexión invalida: " + ae.Message);
            }


            string testResult = configurationDAL.TestConnection(conString);
            if (!string.IsNullOrEmpty(testResult)) {
                errors.Add(testResult);
            } else  {
                var exists = configurationDAL.ExistCatalog(conString);

                /**
                crear existe 
                    1       1  = error
                    1       0  = caso feliz
                    0       1  = caso feliz
                    0       0  = error
                **/
                
                if (create)
                {
                    if (exists)
                    {
                        errors.Add("Ya existe una base de datos con ese nombre creada. Seleccione un nombre distinto o desactive la opción para crear nuevamente la base de datos.");
                    }
                    else
                    {
                        string createResult = CreateDatabase(conString);
                        if (!string.IsNullOrEmpty(createResult))
                            errors.Add(createResult);
                    }
                } else
                {
                    if (!exists)
                    {
                        errors.Add("No existe una base de datos con ese nombre creada. Seleccione un nombre distinto o active la opción para crear la base de datos.");
                    }
                }
            }

            if (errors.Count == 0)
            {
                configurationDAL.SaveConnectionString(conString);

            }

            return errors;
        }

        private string CreateDatabase(string conString)
        {
            string result = this.configurationDAL.CreateDatabase(conString);
            
            return result;
        }

        public string GetConnectionString()
        {
           return configurationDAL.CurrentConnectionString(); 
        }

        public bool IsConnectionConfigured()
        {
            return string.IsNullOrEmpty(GetConnectionString()) == false;
        }


        
    }
}
