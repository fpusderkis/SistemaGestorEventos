using SistemaGestorEventos.BE;
using SistemaGestorEventos.SharedServices.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public class CustomerDAL : AbstractDAL
    {

        private static CustomerDAL _instance = new CustomerDAL();
        public static CustomerDAL Instance { get { return _instance; } }
        private CustomerDAL() { }

        public Customer FindByTaxPayerId(string taxPayerId)
        {
            IList<Customer> customers;
            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);
                db.AddParameter("@taxPayerId", taxPayerId);
                customers = db.ExecuteQuery<Customer>("select * from Customers WHERE TaxPayerId like @taxPayerId ", false);
            }

            if (customers.Count > 0)
            {
                return customers[0];
            }
            else
            {
                return null;
            }
        }

        public Customer FindByEmail(string mail)
        {
            IList<Customer> customers;
            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);
                db.AddParameter("@mail", mail);
                customers = db.ExecuteQuery<Customer>("select * from Customers where Mail like @mail", false);
            }

            if (customers.Count > 0)
            {
                return customers[0];
            }
            else
            {
                return null;
            }
        }

        public int SaveCustomer(Customer encripted)
        {
            using (var con = this.GetSqlConnection())
            {
                con.Open();


                var db = new Database(con);
                if (encripted.Id != null)
                {
                    db.AddParameter("@Id", encripted.Id);
                } else
                {
                    db.AddParameter("@Id", DBNull.Value);
                }
                db.AddParameter("@Name", encripted.Name)
                    .AddParameter("@LastName", encripted.LastName)
                    .AddParameter("@Mail", encripted.Mail)
                    .AddParameter("@Phone", encripted.Phone)
                    .AddParameter("@Address", encripted.Address)
                    .AddParameter("@ZipCode", encripted.ZipCode)
                    .AddParameter("@TaxPayerId", encripted.TaxPayerId)
                    .AddOutParameter("@GeneratedId", System.Data.SqlDbType.Int);
                    
                db.ExecuteNonQuery("sp_Customer_Upsert", true);
                var result = db.ReadOutputParameter<Int32>("@GeneratedId");
                
                return result;

            }
        }

        public IList<Customer> FindByName(string name)
        {
            IList<Customer> customers;

            String nameToFind = name.Replace(" ", "%");

            using (var connection = this.GetSqlConnectionOpen())
            {
                var db = new Database(connection);
                db.AddParameter("@name", "%" + name+ "%");
                customers = db.ExecuteQuery<Customer>("select * from Customers where CONCAT(Name, ' ', LastName) like @Name", false);
                return customers;
            }
        }
    }
}
