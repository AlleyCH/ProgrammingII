using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public class Customer
    {
        public string CustomerID { get; private set; }

        public string Email { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Order { get; set; }

        //public AdressType Adress { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Customer()
        {
            this.CustomerID = Guid.NewGuid().ToString(); 
        }

        public static void CreateCustomer(string name, DateTime dateOfBirth)
        {
            Customer customer = new Customer()
            {
                FirstName = name,
                DateOfBirth = dateOfBirth
            };
          


        }


    }
}
