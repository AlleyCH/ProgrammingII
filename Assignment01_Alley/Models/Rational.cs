using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_Alley.Models
{
    public class Rational
    {
        public int Denominator { get ; private set; }

        public int Numerator { get ; private set; }

        public Rational(int numerator = 0, int denominator = 1)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public override string ToString()
        {
            return this.Numerator + "/" + this.Denominator;
        }

        public void IncreaseBy(Rational other) 
        {
            int denom = this.Denominator * other.Denominator;
            int numer = (this.Numerator * other.Denominator) + (other.Numerator * this.Denominator);
            Denominator = denom;
            Numerator = numer;
        }

        public void DecreaseBy(Rational other)
        {
            int denom = this.Denominator * other.Denominator;
            int numer = (this.Numerator * other.Denominator) - (other.Numerator * this.Denominator);
            Denominator = denom;
            Numerator = numer;
        }
    }
}
