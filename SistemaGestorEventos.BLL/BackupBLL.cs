using SistemaGestorEventos.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class BackupBLL : AbstractBLL
    {
        #region singleton
        private static readonly BackupBLL _instance = new BackupBLL();

        public static BackupBLL Instance { get { return _instance; } }
        private BackupBLL() { }
        #endregion singleton


        private BackupDAL backupDAL = BackupDAL.Instance;

        public void MakeBackup(string filepath)
        {
            backupDAL.MakeBackup(filepath); 
        }

        public void RestoreBackup(string filepath)
        {
            backupDAL.RestoreBackup(filepath);
        }
    }

}
