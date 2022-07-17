using SistemaGestorEventos.BE;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public class EventDAL : AbstractDAL
    {
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
                } else
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

    }
}
