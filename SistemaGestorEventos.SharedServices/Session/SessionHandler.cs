using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.Session
{
    public class SessionHandler<T> where T : IUser
    {
        private static SessionHandler<T> _session = new SessionHandler<T>();

        private T _user;

        List<Action> suscribers = new List<Action>();

        private SessionHandler() { }

        public static SessionHandler<T> GetInstance { get 
            {
                return _session;
            }
        }

        public T Usuario
        {
            get
            {
                return _user;
            }
        }


        public void Login(T usuario)
        {
            _user = usuario;
            this.FireOnSessionStatusChangeEvent();
        }

        public void Logout()
        {
            _user = default(T);
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
