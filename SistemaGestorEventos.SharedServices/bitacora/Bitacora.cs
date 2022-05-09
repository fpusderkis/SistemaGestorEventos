using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.bitacora
{
    public class Bitacora
    {
        private List<IBitacoraWriter> writers = new List<IBitacoraWriter>();

        public object UserReferenceId { get; set; }

        public void AddWriter(IBitacoraWriter writer) => writers.Add(writer);
        public void Log(string msg)
        {
            this.Log(this.UserReferenceId,msg);
        }

        public void Log(object userReferenceId, string msg)
        {
            writers.ForEach(w => w.Write(userReferenceId?.ToString(), msg));
        }
    }
}
