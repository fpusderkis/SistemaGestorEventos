using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE
{
    public abstract class AbstractEntity<T>
    {
        public T Id { get; set; }
    }
}
