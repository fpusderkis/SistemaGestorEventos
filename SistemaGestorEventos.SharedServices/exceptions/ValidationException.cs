using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.exceptions
{
    public class ValidationException : GenericException
    {
        public ValidationException(String message) : base(message)
        {

        }
    }
}
