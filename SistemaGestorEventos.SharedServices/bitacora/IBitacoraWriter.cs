using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.bitacora
{
    public interface IBitacoraWriter
    {
        /// <summary>
        /// Escribira todo lo que se intente guardar en la bitacora.
        /// </summary>
        /// <param name="userReferenceId">user reference id</param>
        /// <param name="message">message</param>
        public void Write(string userReferenceId, string message, string criticity);

    }
}
