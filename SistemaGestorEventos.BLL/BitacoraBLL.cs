using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.bitacora;
using System;

namespace SistemaGestorEventos.BLL
{
    public class BitacoraBLL : IBitacoraWriter
    {
        private BitacoraBLL() { }

        private static BitacoraBLL instance = new BitacoraBLL();

        public static BitacoraBLL GetInstance { get => instance; }

        public void Write(string userReferenceId, string message)
        {
            Guid? guid = null;
            if (userReferenceId != null)
            {
                guid = Guid.Parse(userReferenceId);
            }

            BitacoraDAL.GetInstance.Write(guid, message);
        }
    }
}
