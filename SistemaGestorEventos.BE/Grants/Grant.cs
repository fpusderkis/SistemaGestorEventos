using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BE.Grants
{
    public class Grant : AbstractComponent
    {
        public override IList<AbstractComponent> Childs
        {
            get
            {
                return new List<AbstractComponent>();
            }

        }

        public override void AddChild(AbstractComponent c)
        {

        }

        public override void RemoveChild(AbstractComponent c)
        {
        }

        public override void Clear()
        {

        }
    }
}
