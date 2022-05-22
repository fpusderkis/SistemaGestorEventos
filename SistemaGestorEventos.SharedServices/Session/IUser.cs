using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.Session
{
    public interface IUser
    {
        public Guid Id { get; }
        public string Username { get; }
    }
}
