using SistemaGestorEventos.BE;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaGestorEventos.DAL
{
    public class AditionalServicesDAL : AbstractDAL
    {
        #region singleton
        private static readonly AditionalServicesDAL instance = new AditionalServicesDAL();

        private AditionalServicesDAL()
        {

        }

        public static AditionalServicesDAL Instance => instance;

        #endregion

        internal Service FindServiceById(Int32? serviceId, SqlConnection connection)
        {
            var db = new Database(connection);
            db.AddParameter("@Id", serviceId);
            var services = db.ExecuteQuery<Service>("SELECT * FROM [Services] WHERE Id = @Id;");

            if (services.Count > 0)
            {
                return services[0];
            }
            else return null;
        }

        public IList<Service> FindServicesByName(string name)
        {
            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);
                var sql = "SELECT * FROM [Services] ";

                if (!string.IsNullOrWhiteSpace(name))
                {
                    db.AddParameter("@Name", $"%{name}%");
                    sql = sql + " WHERE Name like @Name ";
                }
                
                var services = db.ExecuteQuery<Service>(sql);


                return services;

            }
            
        }

        public void SaveService(Service service)
        {
            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);

                if (service.Id != null)
                {
                    db.AddInOutParameter("@Id", service.Id, System.Data.SqlDbType.Int);
                }
                else
                {
                    db.AddOutParameter("@Id", System.Data.SqlDbType.Int);
                }

                db.AddParameter("@Name", service.Name)
                    .AddParameter("@ProviderPrice", service.ProviderPrice)
                    .AddParameter("@Fee", service.Fee)
                    .AddParameter("@Status", service.Status)

                    ;


                db.ExecuteNonQuery("sp_Services_Upsert", true);
                service.Id = db.ReadOutputParameter<Int32>("@Id");
            }
        }

        public AditionalService SaveAditionalService(AditionalService aditionalService)
        {
            using (var connection = this.GetSqlConnectionOpen())
            {
                return this.SaveAditionalService(aditionalService, connection);
            }
                
        }
        internal AditionalService SaveAditionalService(AditionalService aditionalService, SqlConnection connection)
        {
            var db = new Database(connection);

            db.AddInOutParameter("@Id", aditionalService.Id, System.Data.SqlDbType.Int);
            db.AddParameter("@ServiceId", aditionalService.Service.Id);
            db.AddParameter("@EventId", aditionalService.EventId);
            db.AddParameter("@Quantity", aditionalService.Quantity);
            db.AddParameter("@Price", aditionalService.Price); 
            db.AddParameter("@Status", aditionalService.Status); 
            db.AddParameter("@Description", aditionalService.Description); 

            db.ExecuteNonQuery("sp_AditionalService_Upsert",true);

            aditionalService.Id = db.ReadOutputParameter<int>("@Id");
            return aditionalService;
        }
    }
}