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
            writers.ForEach(w => w.Write(this.UserReferenceId?.ToString(), msg));
        }
    }
}
