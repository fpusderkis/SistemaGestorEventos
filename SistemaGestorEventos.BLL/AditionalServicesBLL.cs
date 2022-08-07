using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.i18n;
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

        public List<string> ValidateAditionalService(AditionalService aserv)
        {
            var errors = new List<string>();
            
            if (aserv.Quantity < 1)
            {
                errors.Add(MultiLang.TranslateOrDefault("aditionalservice.error.quantity.minimum", "El minimo a contratar por cada servicio es de 1"));
            }

            if (aserv.Price >= aserv.Service.ProviderPrice)
            {
                errors.Add(MultiLang.TranslateOrDefault("aditionalservice.error.providerprice.minimum", "El precio sugerido excede el precio minimo permitido."));
            }

            return errors;
        }
    }
}
