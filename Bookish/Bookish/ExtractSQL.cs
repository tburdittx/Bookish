using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Bookish
{
    public class ExtractSql
    {
        IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookish"].ConnectionString);

        public List<Books> ExtractBooks()
        {
            var sqlString = ("SELECT TOP 100 [bookID],[ISBN],[Title],[Author],[Barcode] FROM [Books]");
            var listofBooks = (List<Books>)db.Query<Books>(sqlString);
            return listofBooks;
        }

        public List<Customers> ExtractCustomers()
        {
            var sqlString = "SELECT TOP 100 [CUSTOMERID],[FirstName],[Surname],[TelephoneNumber],[EmailAddress],[Username],[Password] FROM [Customers]";
            var listofCustomers = (List<Customers>) db.Query<Customers>(sqlString);
            return listofCustomers;
        }
    }
}
