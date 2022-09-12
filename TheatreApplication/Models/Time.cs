using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreApplication.Models
{
    public struct Time
    {
        private const int hours = 1440;
        private const int minutes = 60;

        public int Hours { get; private set; }
        public int Minutes { get; private set; }



        public Time(int hours, int minutes = 0)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public override string ToString()
        {
            return ($"{Hours}:{Minutes}");
        }

        public static bool operator ==(Time lhs, Time rhs) // I don't really understand this method....
        { 
            int leftSide = 1;  // what equation does it want from me??
            int rightSide = 2; // what equation does it want from me??
            int difference = leftSide - rightSide;


            if (difference > 15)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }

        public static bool operator !=(Time lhs, Time rhs) // Nor do I understand this one....
        {
            int leftSide = 1;  // what equation does it want from me??
            int rightSide = 2; // what equation does it want from me??
            int difference = leftSide - rightSide;


            if (difference < 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
