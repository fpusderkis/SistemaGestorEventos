using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.Cyphers;
using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class CustomerBLL : AbstractBLL
    {
        private static readonly CustomerBLL _instance = new CustomerBLL();

        private CryptoManager cryptoManager = new CryptoManager("ModuloUsuariosKey");

        private readonly CustomerDAL customerDAL = CustomerDAL.Instance;

        public static CustomerBLL Instance { get { return _instance; } }
        private CustomerBLL() { }

        public List<string> SaveCustomer(Customer customer)
        {
            var errors = ValidateCustomer(customer);
            if (errors.Count > 0) return errors;

            Customer encripted = EncryptCustomer(customer);
                
            var savedCustomer = customerDAL.FindByTaxPayerId(encripted.TaxPayerId);
            if (savedCustomer != null && savedCustomer.Id != customer.Id)
            {
                errors.Add(MultiIdioma.TranslateOrDefault("errors.customer.taxPayerId.exists", "Ya existe un cliente registrado con ese mismo CUIT/CUILT"));
                return errors;
            }
            

            savedCustomer = customerDAL.FindByEmail(encripted.Mail);

            if (savedCustomer != null && savedCustomer.Id != customer.Id)
            {
                errors.Add(MultiIdioma.TranslateOrDefault("errors.customer.taxPayerId.exists", "Ya existe un cliente registrado con ese mismo CUIT/CUILT"));
                return errors;
            }

            int id = customerDAL.SaveCustomer(encripted);

            BitacoraSingleton.GetInstance.Log($"Cliente {id} guardado con éxito");

            return errors;

        }

        public List<Customer> FindCustomer(string taxPayerId, string mail, string name)
        {
            

            if (!string.IsNullOrWhiteSpace(taxPayerId))
            {
                string taxPayerIdEnc = cryptoManager.EncriptAES(taxPayerId);
                var customer = customerDAL.FindByTaxPayerId(taxPayerIdEnc);
                if (customer != null)
                {
                    var list = new List<Customer>(1);
                    list.Add(DescryptCustomer(customer));
                    return list;
                }
            } else if (!string.IsNullOrWhiteSpace(mail))
            {
                string mailEnc = cryptoManager.EncriptAES(mail);
                var customer = customerDAL.FindByEmail(mailEnc);
                if (customer != null)
                {
                    var list = new List<Customer>(1);
                    list.Add(DescryptCustomer(customer));
                    return list;
                }

            } else if (!string.IsNullOrWhiteSpace(name))
            {
                IList<Customer> customers = customerDAL.FindByName(name);
                if (customers != null && customers.Count > 0)
                {
                    var list = new List<Customer>(1);
                    foreach (var c in customers)
                    {
                        list.Add(DescryptCustomer(c));
                    }
                    
                    return list;
                }
            }

            return null; 

            
        


        }

        private Customer EncryptCustomer(Customer customer)
        {
            var encripted = new Customer
            {
                Id = customer.Id,
                Name = customer.Name,
                LastName = customer.LastName,
                TaxPayerId = cryptoManager.EncriptAES(customer.TaxPayerId),
                ZipCode = customer.ZipCode,
                Mail = cryptoManager.EncriptAES(customer.Mail),
                Phone = customer.Phone,
                Address = cryptoManager.EncriptAES(customer.Address)
            };
            return encripted;
        }

        private Customer DescryptCustomer(Customer customer)
        {
            var encripted = new Customer
            {
                Id = customer.Id,
                Name = customer.Name,
                LastName = customer.LastName,
                TaxPayerId = cryptoManager.DecryptAES(customer.TaxPayerId),
                ZipCode = customer.ZipCode,
                Mail = cryptoManager.DecryptAES(customer.Mail),
                Phone = customer.Phone,
                Address = cryptoManager.DecryptAES(customer.Address)
            };
            return encripted;
        }


        private List<string> ValidateCustomer(Customer customer)
        {
            List<string> errors = new List<string>();
            if (String.IsNullOrWhiteSpace(customer.Name)) errors.Add(MultiIdioma.TranslateOrDefault("errors.customer.name.required", "Ingrese el nombre del cliente"));
            if (String.IsNullOrWhiteSpace(customer.LastName)) errors.Add(MultiIdioma.TranslateOrDefault("errors.customer.lastname.required", "Ingrese el Apellido del cliente"));
            if (String.IsNullOrWhiteSpace(customer.TaxPayerId)) errors.Add(MultiIdioma.TranslateOrDefault("errors.customer.taxpayerid.required", "Ingrese el CUIT/CUIL del cliente"));
            if (String.IsNullOrWhiteSpace(customer.Mail)) errors.Add(MultiIdioma.TranslateOrDefault("errors.customer.mail.required", "Ingrese el Mail del cliente"));
            if (String.IsNullOrWhiteSpace(customer.Phone)) errors.Add(MultiIdioma.TranslateOrDefault("errors.customer.phone.required", "Ingrese el Teléfono del cliente"));
            if (String.IsNullOrWhiteSpace(customer.Address)) errors.Add(MultiIdioma.TranslateOrDefault("errors.customer.address.required", "Ingrese el domicilio del cliente"));

            return errors;
        }
    }
}
