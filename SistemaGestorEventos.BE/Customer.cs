using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Customer : AbstractIdEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Mail { get; set; }

        public string TaxPayerId { get; set; }

        public string Phone { get; set; }

        public string ZipCode { get; set; }

        public string Address { get; set; }


    }
}
