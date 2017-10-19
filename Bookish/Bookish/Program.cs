using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            

            

            foreach (var Book in books)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\nBook ID: " + Book.bookID);
                Console.WriteLine("ISBN: " + Book.ISBN);
                Console.WriteLine("Title: " + Book.Title);
                Console.WriteLine("Author " + Book.Author);
                Console.WriteLine("Barcode " + Book.Barcode + "\n");
                Console.WriteLine(new string('*', 20));
            }

            var customers = (List<Customers>)db.Query<Customers>(SqlString1);

            foreach (var customer in customers)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\nCustomer ID: " + customer.CustomerId);
                Console.WriteLine("First Name: " + customer.FirstName);
                Console.WriteLine("Surname: " + customer.Surname);
                Console.WriteLine("Telephone Number " + customer.TelephoneNumber);
                Console.WriteLine("Email Address " + customer.EmailAddress);
                Console.WriteLine("Username " + customer.Username);
                Console.WriteLine("Password " + customer.Password + "\n");
                Console.WriteLine(new string('*', 20));
            }
            Console.ReadLine();

        }

        private static void ExtractSQL()
        {
            throw new NotImplementedException();
        }

        private static void ExtractSQL(out IDbConnection db, out string SqlString, out string SqlString1)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlString = "SELECT TOP 100 [bookID],[ISBN],[Title],[Author],[Barcode] FROM [Books]";
            SqlString1 = "SELECT TOP 100 [CUSTOMERID],[FirstName],[Surname],[TelephoneNumber],[EmailAddress],[Username],[Password] FROM [Customers]";
        }
    }
}
