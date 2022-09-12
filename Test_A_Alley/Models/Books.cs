using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_A_Alley.Models
{
    public class Books
    {
        public string ISBN { get; private set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string Genre { get; set; }

        public Books()
        {      

            this.ISBN = Guid.NewGuid().ToString();
        }

        
        public override string ToString()
        {

            return ($"Books borrowed: \n ISBN: {ISBN}, Title: {BookTitle}, Author: {BookAuthor}");
        }
  
    }
}
