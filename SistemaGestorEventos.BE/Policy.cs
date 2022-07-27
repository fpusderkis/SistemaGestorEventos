using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Policy : AbstractIdEntity
    {

        public int ReferenceId { get; set; }

        public PolicyType Type { get; set; }

        public int MinDays { get; set; }

        public decimal Penalty { get; set; }

        public bool Active { get; set; }

        public Int32? ReplaceOf { get; set; }

    }
}
