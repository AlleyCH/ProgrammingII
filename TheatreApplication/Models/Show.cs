using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreApplication.Models
{
    public class Show
    {
        public double Price { get; }
        public Day Day { get;  }
        public Movie Movie { get; }
        public Time Time { get; }


        public Show(Movie movie, Day day, double price, Time time)
        {
            movie = Movie;
            day = Day;
            price = Price;
            time = Time;
        }
        public override string ToString()
        {
            return ($" Movie: {Movie} \n Show: {Price}");
        }
    }
}
