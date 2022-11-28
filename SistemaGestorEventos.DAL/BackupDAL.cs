using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public class BackupDAL : AbstractDAL
    {
        #region singleton
        private static readonly BackupDAL instance = new BackupDAL();

        private BackupDAL()
        {

        }

        public static BackupDAL Instance => instance;

        #endregion

        public void MakeBackup(string filepath)
        {
            var sqlString = $"BACKUP DATABASE @DbName TO DISK = @filepath";

            using (var con = this.GetSqlConnectionOpen())
            {
                var db = new Database(con)
                    .AddParameter("@DbName", con.Database)
                    .AddParameter("@filepath", filepath)
                    .ExecuteNonQuery(sqlString);

            }
        }

        public void RestoreBackup(string filepath)
        {

            using (var con = this.GetSqlConnectionOpen())
            {
                var dbName = con.Database;
                new Database(con)
                    .ExecuteNonQuery($"ALTER DATABASE {dbName} SET Single_User WITH Rollback Immediate");

                new Database(con)
                    .AddParameter("@DbName", dbName)
                    .AddParameter("@filepath", filepath)
                    .ExecuteNonQuery("USE master; RESTORE DATABASE @DbName FROM DISK = @filepath WITH REPLACE;");

                new Database(con)
                    .AddParameter("@DbName", dbName)
                    .AddParameter("@filepath", filepath)
                    .ExecuteNonQuery($"USE master; RESTORE DATABASE {dbName} FROM DISK = @filepath WITH REPLACE;");

                new Database(con)
                   .ExecuteNonQuery($"ALTER DATABASE {dbName} SET Multi_User");

                BitacoraSingleton.Log("Backup restored from disk: " + filepath);

            }

        }
    }
}
