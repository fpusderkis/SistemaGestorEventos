using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.Session
{
    public class SessionHandler
    {
        private static SessionHandler _session = new SessionHandler();

        private IUser _user;

        List<Action> suscribers = new List<Action>();

        private SessionHandler() { }

        public static SessionHandler GetInstance { get 
            {
                return _session;
            }
        }

        public IUser Usuario
        {
            get
            {
                return _user;
            }
        }


        public void Login(IUser usuario)
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

    }
}
