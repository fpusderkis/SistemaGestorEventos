using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public class BitacoraDAL : AbstractDAL
    {

        private BitacoraDAL() { }

        private static BitacoraDAL instance = new BitacoraDAL();

        public static BitacoraDAL GetInstance { get => instance; }

        public void Write(Guid? userId, string message)
        {

            this.InvokeProcedure("sp_GuardarBitacora", new Dictionary<string,object>() {
                { "@userId", userId },
                { "@message", message }
            });
            
        }

    }
}
