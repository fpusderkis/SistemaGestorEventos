using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.bitacora
{
    public class BitacoraSingleton
    {
        private static Bitacora bitacora = new Bitacora();

        public static Bitacora GetInstance { get { return bitacora; } }
    }
}
