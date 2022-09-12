using System;
using Assignment01_Alley.Models;

namespace Assignment01_Alley
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational[] rational = new Rational[] {

            new Rational(numerator: 1, denominator: 4),
            new Rational(numerator: 0, denominator: 3),
            new Rational(numerator: 2, denominator: 5),
            new Rational(numerator: 1, denominator: 2),
        };
            Console.WriteLine($"the first rational number is: {rational[3]}, the second rational number is: {rational[1]}");
            Console.Write($"{rational[3]} + {rational[1]} = ");
            rational[3].IncreaseBy(rational[1]);
            Console.WriteLine(rational[3]);

            Console.WriteLine();

            Console.WriteLine($"the first rational number is: {rational[2]}, the second rational number is: {rational[0]}");
            Console.Write($"{rational[2]} - {rational[0]} = ");
            rational[2].DecreaseBy(rational[0]);
            Console.WriteLine(rational[2]);
        }
    }
}
