using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_A_Alley.Models
{
    public class Address
    {
        public string AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int StreetNo { get; set; }

        public Address()
        {
             this.AddressId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return ($"Address: \n {StreetNo}{Street}{AddressLine1}{Province}{PostalCode}{Country}");
        }

    }
}
