using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class AditionalServicesBLL
    {
        #region singleton
        private static readonly AditionalServicesBLL _instance = new AditionalServicesBLL();

        public static AditionalServicesBLL Instance { get { return _instance; } }
        private AditionalServicesBLL() { }
        #endregion singleton

        private AditionalServicesDAL aditionalServiceDAL = AditionalServicesDAL.Instance;

        public IList<Service> FindServicesByName(string name)
        {
            return aditionalServiceDAL.FindServicesByName(name);
        }


    }
}
