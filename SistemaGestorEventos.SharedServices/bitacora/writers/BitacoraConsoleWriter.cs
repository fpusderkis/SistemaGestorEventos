using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.bitacora.writers
{
    public class BitacoraConsoleWriter : IBitacoraWriter
    {
        public void Write(string userReferenceId, string message, string criticity)
        {
            Console.WriteLine($"[citicity:{criticity}][datetime:{DateTime.Now}][userReferenceId:{ userReferenceId }] {message}");
        }
    }
}
