using System;
using Assignment02_Alley.Models;

namespace Assignment02_Alley
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File contents: \n");

            TweetManager.ShowAll();

            TweetManager.Initialize();

            TweetManager.ShowAll("Ford");



        }
    }
}
