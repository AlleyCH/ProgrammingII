using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreApplication.Models
{
    public class Movie
    {
        public int Length { get; }
        public int Year { get;  }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast { get; }


        public Movie(string name, int year, int length)
        {
            name = Title;
            year = Year;
            length = Length;
            Cast = new List<string>(); 
        }


        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }

        public void SetGenre(Genre genre)
        {
            genre = Genre;
        }

        public override string ToString()
        {
            return string.Join(", ", Cast);
        }
    }
}
