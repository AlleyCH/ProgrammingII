using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreApplication.Models
{
    public class Theatre
    {
        private List<Show> shows;

        public string Name { get; }


        public Theatre(string name)
        {
            name = Name;
            shows = new List<Show>();            
        }

        public void AddShow(Show show)
        {
            shows.Add(show);
        }

        public void PrintShows()
        {
            foreach (Show show in shows)
            {
                Console.WriteLine(show); // I know not to do this!
            }

        }
        public void PrintShows(Genre genre)
        {
            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine($"Show: {shows} Genres: {genre}"); // I know not to do this!
                }
            }
        }

        public void PrintShows(Day day)
        {
            foreach (Show show in shows)
            {
                if (show.Day == day)
                {
                    Console.WriteLine($"Show: {shows} Day: {day}"); // I know not to do this!
                }
            }
        }

        public void PrintShows(Time time)
        {
            foreach (Show show in shows)
            {
                if (show.Time == time)
                {
                    Console.WriteLine($"Show: {shows} Time: {time}"); // I know not to do this!
                }
            }
        }
        public void PrintShows(string actor)
        {
            foreach (Show show in shows)
            {
                if (show.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine($"Show: {shows} Actor: {actor}"); // I know not to do this!
                }
            }
        }
        public void PrintShows(Day day, Time time)
        {
            foreach (Show show in shows)
            {
                if (show.Day == day && show.Time == time)
                {
                    Console.WriteLine($"Show: {shows} Day: {day} Time: {time}"); // I know not to do this!
                }
            }
        }
    }
}
