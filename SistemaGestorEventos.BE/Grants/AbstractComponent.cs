using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE.Grants
{
    public abstract class AbstractComponent : AbstractEntity
    {
        public string Name { get; set; }
        
        public abstract IList<AbstractComponent> Childs { get; }
        public abstract void AddChild(AbstractComponent c);

        public abstract void RemoveChild(AbstractComponent c);

        public abstract void Clear();
        public GrantType? GrantType { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
