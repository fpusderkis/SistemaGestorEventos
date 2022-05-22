using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL.Exceptions
{
    public class PasswordExpiredException : BusinessException
    {
        public PasswordExpiredException() : base("login.password.expired","Expiro su password, ingrese uno nuevo"){ }
    }
}
