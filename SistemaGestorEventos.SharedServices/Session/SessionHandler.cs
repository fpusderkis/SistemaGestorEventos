using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.Session
{
    public class SessionHandler<T>
    {
        private static SessionHandler<T> _session = new SessionHandler<T>();

        private IUser<T> _user;

        List<Action> suscribers = new List<Action>();

        private SessionHandler() { }

        public static SessionHandler<T> GetInstance { get 
            {
                return _session;
            }
        }

        public IUser<T> Usuario
        {
            get
            {
                return _user;
            }
        }


        public void Login(IUser<T> usuario)
        {
            _user = usuario;
            this.FireOnSessionStatusChangeEvent();
        }

        public void Logout()
        {
            _user = null;
            this.FireOnSessionStatusChangeEvent();
        }

        public bool IsLogged()
        {
            return _user != null;
        }

        public bool IsNotLogged()
        {
            return !IsLogged();
        }


        public void SuscribeSessionStatusChangeEvent(Action action)
        {
            suscribers.Add(action);
        }


        private void FireOnSessionStatusChangeEvent() 
        {
            suscribers.ForEach(s => s());
        }


        public bool TienePermiso(T permiso)
        {
            if (IsLogged())
            {
                return _user.TienePermiso(permiso);
            }
            return false;
        }
    }
}
