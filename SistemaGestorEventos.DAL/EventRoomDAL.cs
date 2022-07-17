using SistemaGestorEventos.BE;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public class EventRoomDAL : AbstractDAL
    {
        private readonly static EventRoomDAL instance = new EventRoomDAL();

        private EventRoomDAL() { }

        public static EventRoomDAL Instance => instance;

        public IList<EventRoom> FindAvailable(Int32? id, string name, DateTime from, DateTime to)
        {

            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);

                var sql = $"SELECT * FROM[EventRooms] eroom where 1=1 ";

                if (id != null)
                {
                    db.AddParameter("@Id", id);
                    sql += " AND Id = @Id ";
                }

                if (!string.IsNullOrWhiteSpace(name))
                {
                    db.AddParameter("@Name", $"%{name}%");
                    sql += " AND Name like @Name ";
                }                

                if (from != null && to != null)
                {
                    var existQuery = " AND NOT EXISTS(SELECT * FROM Events ev where ev.Status is not null AND ev.Status not in ('PRESUPUESTADO') AND ev.EventRoomId = eroom.Id ";
                    existQuery += " AND ev.DateFrom > @DateFrom AND ev.DateTo < @DateTo ) ";

                    db.AddParameter("@DateFrom", from);
                    db.AddParameter("@DateTo", to);

                    sql += existQuery;
                }


                return db.ExecuteQuery<EventRoom>(sql);
            }


        }

    }
}
