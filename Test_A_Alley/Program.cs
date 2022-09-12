using System;
using Test_A_Alley.Models;
using System.Xml.Serialization;
using System.IO;


namespace Test_A_Alley
{
    class Program
    {
        static void Main(string[] args)
        {
            Patrons.Create(); // creates library users as objects
            Patrons.Get(); // reads the library users on console


            Books book = new Books()
            {
                BookTitle = "Harry Potter",
                BookAuthor = "J. K. Rowling",
                Genre = "Fantasy",              
            };

            Address address = new Address()
            {
                City = "Toronto, ",
                Province = "ON, ",
                PostalCode = "M2R1N9 ",
                Country = "Canada ",
                Street = " Bloor ",
                AddressLine1 = "Apt# 901. ",
                StreetNo = 730 ,
            };

            Console.WriteLine();
            Console.WriteLine($"{book}");
            Console.WriteLine();
            Console.WriteLine($"{address}");

        }
    }
}
