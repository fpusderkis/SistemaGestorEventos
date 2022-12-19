using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.Persistance
{
    public class DatabaseDatasource
    {

        private string REGISTRY_KEY_DATASOURCE_PATH = @"SOFTWARE\SGE";
        private string REGISTRY_KEY_DATASOURCE_VALUE = @"datasourcesge";


        public static DatabaseDatasource Instance => new DatabaseDatasource();

        private DatabaseDatasource() {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY_DATASOURCE_PATH);

            if (key != null)
            {
                var conString = key.GetValue(REGISTRY_KEY_DATASOURCE_VALUE);

                if (conString != null)
                {
                    this.ConnectionString = conString.ToString();
                }
            }
            
        }

        public void UpdateRegistryConnectionString(string conString)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY_DATASOURCE_PATH,true);

            if (key == null)
            {
                key = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY_DATASOURCE_PATH);
            }

            key.SetValue(REGISTRY_KEY_DATASOURCE_VALUE, conString);
            key.Close();
            this.ConnectionString = conString;
        }



        public string ConnectionString { get; set; } = "";
    }
}
