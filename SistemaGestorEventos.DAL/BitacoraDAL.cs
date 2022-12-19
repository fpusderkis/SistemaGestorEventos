using SistemaGestorEventos.BE;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;


namespace SistemaGestorEventos.DAL
{
    public class BitacoraDAL : AbstractDAL
    {

        private BitacoraDAL() { }

        private static BitacoraDAL instance = new BitacoraDAL();

        public static BitacoraDAL GetInstance { get => instance; }

        public void Write(Guid? userId, string message, string criticity)
        {

            this.InvokeProcedure("sp_GuardarBitacora", new Dictionary<string,object>() {
                { "@userId", userId },
                { "@message", message },
                { "@criticity", criticity }
            });
            
        }

        public IList<Log> SearchLogs(string username, DateTime from, DateTime to, string criticity)
        {
            using (var con = this.GetSqlConnectionOpen())
            {
                var db = new Database(con);

                var sql = "SELECT l.id id, u.username username, l.creationDate creationDate, l.message message, l.criticity criticity FROM Logs l LEFT JOIN Usuarios u ON l.userId = u.id where creationDate > @fromDate AND creationDate < @toDate ";

                db.AddParameter("@fromDate", from).AddParameter("@toDate", to);

                if (!string.IsNullOrEmpty(username))
                {
                    sql += " AND u.username like @username ";
                    db.AddParameter("@username", username);
                }

                if (!string.IsNullOrEmpty(criticity))
                {
                    sql += " AND l.criticity like @criticitiy ";
                    db.AddParameter("@criticitiy", criticity);
                }

                return db.ExecuteQuery<Log>(sql);

            }

            ;
        }
    }
}
