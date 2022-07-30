using SistemaGestorEventos.BE;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public class EventDAL : AbstractDAL
    {
        private AditionalServicesDAL serviceDAL = AditionalServicesDAL.Instance;
        private static readonly EventDAL instance = new EventDAL();

        private EventDAL()
        {

        }

        public static EventDAL Instance => instance;

        public Event SaveEvent(Event evt)
        {
            using (var con = this.GetSqlConnectionOpen())
            {
                var db = new Database(con);

                if (evt.Id != null)
                {
                    db.AddInOutParameter("@Id", evt.Id, System.Data.SqlDbType.Int);
                }
                else
                {
                    db.AddOutParameter("@Id", System.Data.SqlDbType.Int);
                }

                db.AddParameter("@Title", evt.Title);
                db.AddParameter("@Description", evt.Description);
                db.AddParameter("@MinBudget", evt.MinBudget);
                db.AddParameter("@MaxBudget", evt.MaxBudget);
                db.AddParameter("@Guess", evt.GuessQuantity);
                db.AddParameter("@EventType", evt.EventType.ToString());
                db.AddParameter("@EventRoomId", evt.EventRoom?.Id);
                db.AddParameter("@EventRoomDetails", evt.EventRoomDetails);
                db.AddParameter("@EventRoomPrice", evt.EventRoomPrice);
                db.AddParameter("@CustomerId", evt.Customer.Id);

                if (evt.ModifiedBy != null)
                {
                    db.AddParameter("@UserId", evt.ModifiedBy.Id);
                }
                else
                {
                    db.AddParameter("@UserId", evt.CreatedBy.Id);
                }


                db.AddParameter("@SpecialRequest", evt.SpecialRequest);
                db.AddParameter("@Status", evt.Status.ToString());
                db.AddParameter("@DateFrom", evt.DateFrom);
                db.AddParameter("@DateTo", evt.DateTo);


                /// TODO save aditional services
                /// evt.AditionalServices



                db.ExecuteNonQuery("sp_Event_Upsert", true);

                evt.Id = db.ReadOutputParameter<Int32>("@Id");

            }

            return evt;
        }


        public IList<Event> FindEvents(Int32? eventId, Int32? customerId, string title, DateTime? from, DateTime? to, EventStatus? status)
        {
            var sql = "SELECT * FROM EVENTS WHERE 1=1 ";

            using (var con = this.GetSqlConnectionOpen())
            {
                var db = new Database(con);

                if (eventId != null && eventId > 0)
                {
                    sql = sql + " AND ID = @Id";
                    db.AddParameter("@Id", eventId);
                }
                if (customerId != null && customerId > 0)
                {
                    sql = sql + " AND CustomerId = @CustomerId";
                    db.AddParameter("@CustomerId", customerId);
                }
                if (!string.IsNullOrWhiteSpace(title))
                {
                    sql = sql + " AND Title like @Title";
                    db.AddParameter("@Title", $"%{title}%");
                }
                if (from != null)
                {
                    sql = sql + " AND DateFrom > @DateFrom";
                    db.AddParameter("@DateFrom", from);
                }

                if (to != null)
                {
                    sql = sql + " AND DateFrom < @DateTo";
                    db.AddParameter("@DateTo", to);
                }

                if (status != null)
                {
                    sql = sql + " AND STATUS < @Status";
                    db.AddParameter("@Status", status.ToString());
                }


                var events = db.ExecuteQuery<Event>(sql);

                return events;
            }

        }

        public Event LoadFullEvent(Event evt)
        {
            using (var con = this.GetSqlConnectionOpen())
            {
                var db = new Database(con);
                db.AddParameter("@Id", evt.Id);

                var sqlEventRoom = "SELECT er.* FROM EVENTS evt INNER JOIN EventRooms er ON er.Id = evt.EventRoomId WHERE evt.Id = @Id ";
                var rooms = db.ExecuteQuery<EventRoom>(sqlEventRoom);

                if (rooms.Count == 1)
                {
                    evt.EventRoom = rooms[0];
                }

                var dbCustomer = new Database(con).AddParameter("@Id", evt.Id);
                var customers = dbCustomer.ExecuteQuery<Customer>("SELECT cx.* FROM [Customers] cx INNER JOIN EVENTS evt ON evt.CustomerId = cx.Id where evt.Id = @Id");

                if (customers.Count > 0)
                {
                    evt.Customer = customers[0];
                }

                var dbCreatedBy = new Database(con).AddParameter("@Id", evt.Id);
                var usersCreatedBy = dbCreatedBy.ExecuteQuery<User>("SELECT u.Id, u.username, u.Name, u.Lastname FROM [Usuarios] u INNER JOIN EVENTS evt ON evt.CreatedBy = u.Id where evt.Id = @Id;");

                if (usersCreatedBy.Count > 0)
                {
                    evt.CreatedBy = usersCreatedBy[0];
                }

                var dbModifiedBy = new Database(con).AddParameter("@Id", evt.Id);
                var usersModifiedBy = dbModifiedBy.ExecuteQuery<User>("SELECT u.Id, u.username, u.Name, u.Lastname FROM [Usuarios] u INNER JOIN EVENTS evt ON evt.LastUpdatedBy = u.Id where evt.Id = @Id;");

                if (usersModifiedBy.Count > 0)
                {
                    evt.CreatedBy = usersCreatedBy[0];
                }

                var dbAditionalServices = new Database(con).AddParameter("@Id", evt.Id);
                var aditionalServices = dbAditionalServices.ExecuteQuery<AditionalService>("SELECT aserv.* FROM [AditionalServices] aserv inner join events evt on evt.Id = aserv.EventId where evt.Id = @Id;");

                if (aditionalServices.Count > 0)
                {
                    foreach (var aserv in aditionalServices)
                    {
                        aserv.Service = serviceDAL.FindServiceById(aserv.ServiceId, con);
                        evt.AditionalServices.Add(aserv);
                    }
                }

                return evt;
            }
        }
    }
}
