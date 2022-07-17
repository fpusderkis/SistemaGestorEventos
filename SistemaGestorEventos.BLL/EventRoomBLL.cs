using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class EventRoomBLL : AbstractBLL
    {

        private static readonly EventRoomBLL instance = new EventRoomBLL();

        private EventRoomDAL eventRoomDAL = EventRoomDAL.Instance;

        private EventRoomBLL()
        {

        }

        public static EventRoomBLL Instance => instance;

        public IList<EventRoom> FindAvailiableEventrooms(Int32? id, string name, DateTime from, DateTime to)
        {
            return this.eventRoomDAL.FindAvailable(id, name, from, to) ;
        }
    }
}
