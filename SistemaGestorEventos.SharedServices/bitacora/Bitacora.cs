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
            Log(userReferenceId, msg, "INFO");
        }

        private void Log(object userReferenceId, string msg, string criticity)
        {
            writers.ForEach(w => {
                    try
                    {
                        w.Write(userReferenceId?.ToString(), msg, criticity);
                    } catch (Exception ex)
                    {
                        //nothing to do here
                    }
                });
        }

        public void Error(string message)
        {
            Log(UserReferenceId,message, "ERROR");
        }

        public void Trace(string message)
        {
            Log(UserReferenceId, message, "TRACE");
        }
    }
}
