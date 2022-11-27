using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public class Guest : AbstractIdEntity
    {
        public string TaxPayerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Quantity { get; set; } = 1;

        public string Details { get; set; }

        public FoodType FoodType { get; set; } = FoodType.INDISTINTO;

        public bool Enabled { get; set;  } = true;

    }


    public enum FoodType
    {
        INDISTINTO, VEGETARIANO, VEGANO, CELIACO
    }
}
