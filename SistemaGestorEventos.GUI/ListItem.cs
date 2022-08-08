using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.GUI
{
    internal class ListItem<K,V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }
}
