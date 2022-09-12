using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public class Adress
    {
        public string AdressID { get; set; }

        public string AdressLine1 { get; set; }

        public string AdressLine2 { get; set; }

        public string city { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        //public AdressType AdressType { get; set; }

        public Adress()
        {
            this.AdressID = Guid.NewGuid().ToString();

        }

        public void RegisterAdress(AdressType)
        {

        }

    }
}
