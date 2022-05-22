using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL.Exceptions
{
    public class BusinessException : Exception
    {
        public String MessageKey { get; set; }
        public String MessageText { get; set; }

        public BusinessException(string messageKey, string messageText, Exception e = null) : base(messageText,e)
        {
            MessageKey=messageKey;
            MessageText = messageText;
        }

    }
}
