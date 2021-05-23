using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.exceptions
{
    public class GenericException : Exception
    {
        public GenericException(string message) : base(message)
        {
            
        }
    }
}
