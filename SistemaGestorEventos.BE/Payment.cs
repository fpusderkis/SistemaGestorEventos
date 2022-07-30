using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Payment : AbstractIdEntity
    {
        public decimal Amount { get; set; }
        public string ConciliationKey { get; set; }
        public PaymentType Type { get; set; }
        public bool Active { get; set; }

        public DateTime PaymentDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt{ get; set; }
        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }

    }
}
