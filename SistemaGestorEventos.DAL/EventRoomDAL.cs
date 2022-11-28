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

        public IList<EventRoom> Find(Int32? id, string name)
        {

            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);

                var sql = $"SELECT * FROM [EventRooms] eroom where 1=1 ";

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

                return db.ExecuteQuery<EventRoom>(sql);
            }


        }

        public Int32 Save(EventRoom eventRoom, Guid userId)
        {
            
            using (var connection = this.GetSqlConnectionOpen())
            {
                
                var db = new Database(connection);

                db.AddInOutParameter("@Id", eventRoom.Id, System.Data.SqlDbType.Int)
                    .AddParameter("@Name", eventRoom.Name)
                    .AddParameter("@Address", eventRoom.Address)
                    .AddParameter("@Capacity", eventRoom.Capacity)
                    .AddParameter("@BucketSize", eventRoom.BucketSize)
                    .AddParameter("@Price", eventRoom.Price)
                    .AddParameter("@Active", eventRoom.Active)
                    .AddParameter("@DVH", eventRoom.DVH)
                    .AddParameter("@UserId", userId);

                db.ExecuteNonQuery("sp_EventRoom_Upsert", true);

                return db.ReadOutputParameter<Int32>("@Id"); ;
            }
        }

        public IList<EventRoom> FindHistory(int id)
        {
            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);

                db.AddParameter("@Id", id);

                return db.ExecuteQuery<EventRoom>("SELECT * FROM EventRooms_Audit era WHERE era.Id = @Id ORDER BY era.AudId desc");
            }
        }

        public IList<EventRoom> FindAll()
        {
            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);

                return db.ExecuteQuery<EventRoom>("SELECT * FROM EventRooms er ORDER BY Id desc");
            }
        }

        public void RegenerateDVV()
        {
            this.InvokeProcedure("sp_GenerateDVV_EventRooms");
        }

        public bool ValidateDVV()
        {
            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);

                decimal scalar = db.ExecuteScalar<decimal>("select sum(dvh)%30000 - ISNULL((select dvv from  INTEGRIDAD_VERTICAL where table_name = 'EventRooms' ),0) from EventRooms");
                return scalar == 0;
            }
        }
    }
}
