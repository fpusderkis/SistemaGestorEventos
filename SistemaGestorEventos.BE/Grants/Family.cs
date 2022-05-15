using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaGestorEventos.BE.Grants
{
    public class Family : AbstractComponent
    {
        private IList<AbstractComponent> _childs;
        public Family()
        {
            _childs = new List<AbstractComponent>();
        }

        public override IList<AbstractComponent> Childs
        {
            get
            {
                return _childs.ToArray();
            }

        }

        public override void Clear()
        {
            _childs = new List<AbstractComponent>();
        }
        public override void AddChild(AbstractComponent c)
        {
            _childs.Add(c);
        }

        public override void RemoveChild(AbstractComponent c)
        {
            _childs.Remove(c);
        }
    }
}
