using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.bitacora;
using System;
using System.Collections.Generic;

namespace SistemaGestorEventos.BLL
{
    public class BitacoraBLL : AbstractBLL, IBitacoraWriter
    {
        private BitacoraBLL() { }

        private static BitacoraBLL instance = new BitacoraBLL();

        public static BitacoraBLL GetInstance { get => instance; }

        public void Write(string userReferenceId, string message, string criticity)
        {
            Guid? guid = null;
            if (userReferenceId != null)
            {
                guid = Guid.Parse(userReferenceId);
            }

            BitacoraDAL.GetInstance.Write(guid, message,criticity);
        }

        public IList<Log> SearchLogs(string username, DateTime from, DateTime to, string criticity)
        {
            
            return BitacoraDAL.GetInstance.SearchLogs(username, from, to, criticity);
        }
    }
}
