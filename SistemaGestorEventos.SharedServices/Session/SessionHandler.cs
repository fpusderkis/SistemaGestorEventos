using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.Session
{
    public class SessionHandler
    {
        private static SessionHandler _session = new SessionHandler();

        private IUser _user;
        private ISet<object> _grants;

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


        public void Login(IUser usuario, ISet<Object> grants)
        {
            _user = usuario;
            _grants = grants;

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

        /// <summary>
        /// TODO que pasa si un suscriptor tira una runtime exception?
        /// </summary>
        private void FireOnSessionStatusChangeEvent() 
        {
            suscribers.ForEach(s => s());
        }


        public bool HasGrant(object grantToCheck)
        {
            if (IsLogged())
            {
                foreach (var grant in _grants)
                {
                    if (grant.Equals(grantToCheck))
                    {
                        return true;
                    }
                }   
            }
            return false;
        }
    }
}
