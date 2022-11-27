using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.bitacora;
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

            if (aserv.Price < aserv.Service.ProviderPrice)
            {
                errors.Add(MultiLang.TranslateOrDefault("aditionalservice.error.providerprice.minimum", "El precio sugerido excede el precio minimo permitido."));
            }

            return errors;
        }

        public void SaveService(Service service)
        {
            aditionalServiceDAL.SaveService(service);
            BitacoraSingleton.Log($"Se guardo el servicio ({service.Id}) {service.Name}");
        }

        public List<string> Confirm(AditionalService aditionalService, decimal realCost)
        {

            var errors = new List<string>();
            if (aditionalService.CalculedPrice < realCost * aditionalService.Quantity)
            {
                errors.Add(MultiLang.TranslateOrDefault("aditionalService.error.costexeded", "Se supero el monto abonado por el cliente."));
            }
            

            if (errors.Count == 0)
            {
                aditionalService.Status = AditionalServiceStatus.CONFIRMED;
                aditionalService.Cost = realCost * aditionalService.Quantity;
                aditionalServiceDAL.SaveAditionalService(aditionalService);
                BitacoraSingleton.Log($"Se confirma el servicio {aditionalService.Id} (evento: {aditionalService.EventId})");
            } 
            
            return errors;
            
        }

        public void CancelProvider(AditionalService aditionalService, decimal realCost)
        {
            aditionalService.Status = AditionalServiceStatus.CANCELED_PROVIDER;
            aditionalService.Cost = realCost * aditionalService.Quantity;
            aditionalServiceDAL.SaveAditionalService(aditionalService);
            BitacoraSingleton.Log($"Se cancela el servicio {aditionalService.Id} (evento: {aditionalService.EventId}) por costo elevado");

        }
    }
}
