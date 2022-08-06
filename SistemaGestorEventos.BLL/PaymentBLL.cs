using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class PaymentBLL
    {
        private static readonly PaymentBLL instance = new PaymentBLL();

        
        private PaymentDAL paymentDAL = PaymentDAL.Instance;


        private PaymentBLL()
        {

        }

        public static PaymentBLL Instance => instance;

        public List<string> SavePayment(Payment payment)
        {
            var errors = ValidatePayment(payment);
            if (errors.Count > 0) return errors;

            var user = (User) SharedServices.Session.SessionHandler.GetInstance.User;
            paymentDAL.SavePayment(payment, user);

            return errors;
        }

        public List<string> ValidatePayment(Payment payment)
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(payment.ConciliationKey))
            {
                errors.Add(MultiLang.TranslateOrDefault("payment.save.conciliationkey.requerided", "Ingrese un criterio de conciliación"));
            }

            if (payment.Amount <= 0)
            {
                errors.Add(MultiLang.TranslateOrDefault("payment.save.amount.requerided", "Indique un monto"));
            }

            if (payment.PaymentDate == null)
            {
                errors.Add(MultiLang.TranslateOrDefault("payment.save.paymentdate.requerided", "Indique la fecha del pago"));
            }

            return errors;
        }
    }
}
