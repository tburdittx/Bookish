using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {

            var booklist = new ExtractSql().ExtractBooks();

            foreach (var book in booklist)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\nBook ID: " + book.bookID);
                Console.WriteLine("ISBN: " + book.ISBN);
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author " + book.Author);
                Console.WriteLine("Barcode " + book.Barcode + "\n");
                Console.WriteLine(new string('*', 20));
            }

            var customers = new ExtractSql().ExtractCustomers();

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
    }
}
