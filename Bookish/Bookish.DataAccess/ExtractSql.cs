using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bookish;
using System.Configuration;
using Dapper;

namespace Bookish.DataAccess
{
    public class ExtractSql
    {
        private readonly IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookish"].ConnectionString);

        public List<Books> ExtractBooks()
        {
            string sqlString = ("SELECT TOP 100 [bookID],[ISBN],[Title],[Author],[Barcode] FROM [Books1]");
            var listofBooks = (List<Books>)_db.Query<Books>(sqlString);
            return listofBooks;
        }

        public List<Customers> ExtractCustomers()
        {
            string sqlString = "SELECT TOP 100 [CUSTOMERID],[FirstName],[Surname],[TelephoneNumber],[EmailAddress],[Username],[Password] FROM [Customers]";
            var listofCustomers = (List<Customers>)_db.Query<Customers>(sqlString);
            return listofCustomers;
        }
    }
}
