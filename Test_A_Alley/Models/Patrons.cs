using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Test_A_Alley.Models
{
    public class Patrons
    {
        public string PatronsId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LibraryCard { get; set; }
        public Address PatronsAddress { get; set; }
        public int NoOfBooks { get; set; }
        
        public DateTime DOB { get; set; }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - this.DOB.Year;

                if (DateTime.Now.DayOfYear < this.DOB.DayOfYear)
                {
                    age--;
                }
                return age;
            }         
        }


        public Patrons()
        {
            this.UserName = Guid.NewGuid().ToString(); 
            this.LibraryCard = Guid.NewGuid().ToString();
            this.PatronsId = Guid.NewGuid().ToString();
        }

     
        public override string ToString()
        {
            return ($"Username is: {UserName}, " +
                $"Age is: {Age}, " +
                $" Patrons library card is: {LibraryCard}");
        }



        // CRUD STATIC METHODS 

        public static void Create()
        {
            Patrons borrower = new Patrons();

            // Username input

            while (true)
            {
                Console.WriteLine("Enter username");
                borrower.UserName = Console.ReadLine();
                string userName = borrower.UserName;

                try
                {
                    if (userName.Length < 3 || userName.Length > 40)
                    {
                        throw new Exception("Enter a username");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error! Please Enter a vaild username. {e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }


            // birthday input

            while (true)
            {
                Console.WriteLine("Enter birthday (year-month-day): ");

                borrower.DOB = DateTime.Parse(Console.ReadLine());
                DateTime dob = borrower.DOB;

                try
                {
                 
                    if (dob.Year < 1900 )
                    {
                        throw new Exception("Enter a valid year");
                 
                    }
                    
                    break;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error! Please try again. {e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // books input 

            while (true)
            {
                Console.WriteLine("Enter How many books you have borrowed: ");

                borrower.NoOfBooks = int.Parse(Console.ReadLine());
                int noBooks = borrower.NoOfBooks;

                try
                {
                    if (noBooks > 20)
                    {
                        throw new Exception("Enter how many books");
                    }
                    break;
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error! Too many books. {e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }                              
            }


            // Serialization

            XmlSerializer serializer = new XmlSerializer(typeof(Patrons));
            using (Stream stream = new FileStream($"C:\\Users\\Alisha\\Desktop\\Midterm_Programming\\Patrons.xml", FileMode.Create))
            {
                serializer.Serialize(stream, borrower);
            }
            Console.WriteLine("XML file has been created");
        }


        public static void Get()
        {            
            
            XmlSerializer serializer = new XmlSerializer(typeof(Patrons));

            string[] files = Directory.GetFiles("C:\\Users\\Alisha\\Desktop\\Midterm_Programming");

            foreach (string file in files)
            {
                using (Stream stream = new FileStream(file, FileMode.Open))
                {
                    Patrons loadedProduct = (Patrons)serializer.Deserialize(stream);

                    Console.WriteLine("Object successfully deserialized! \n");
                    Console.WriteLine(loadedProduct.ToString());
                }
                
            }
        }


        public static void Update()
        {

        }
                      

        public static void Delete()
        {
            File.Delete($"C:\\Users\\Alisha\\Desktop\\Midterm_Programming\\Patrons.xml");
            Console.WriteLine("XML file has been deleted");
        }

    }
}
