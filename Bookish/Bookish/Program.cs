using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;

namespace Bookish
{
    class Program
    {
        

        static void Main(string[] args)
        {
           IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string SqlString = "SELECT TOP 100 [BookID],[ISBN],[Title],[Author],[Barcode] FROM [Books]";
                var Books = (List<Book>)db.Query<Book>(SqlString);

            foreach (var Book in Books)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\nBook ID: " + Book.BookID);
                Console.WriteLine("ISBN: " + Book.ISBN);
                Console.WriteLine("Title: " + Book.Title);
                Console.WriteLine("Author " + Book.Author);
                Console.WriteLine("Barcode " + Book.Barcode + "\n");
                Console.WriteLine(new string('*', 20));
            }

            
            string SqlString1 = "SELECT TOP 100 [ID],[FirstName],[Surname],[ContactNumber],[EmailAddress],[Username],[Password] FROM [Customer]";
            var Customer2 = (List<Customers>)db.Query<Customers>(SqlString1);

            foreach (var Customer1 in Customer2)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\nCustomer ID: " + Customer1.CustomerID);
                Console.WriteLine("First Name: " + Customer1.FirstName);
                Console.WriteLine("Surname: " + Customer1.Surname);
                Console.WriteLine("Telephone Number " + Customer1.TelephoneNumber);
                Console.WriteLine("Email Address " + Customer1.EmailAddress);
                Console.WriteLine("Username " + Customer1.Username);
                Console.WriteLine("Password " + Customer1.Password +"\n");
                Console.WriteLine(new string('*', 20));
            }
            Console.ReadLine();
        }
    }
}
