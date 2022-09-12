using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Alley.Models
{
    public static class TweetManager
    {

        private static List<Tweet> TWEETS { get; set; } 
        private static string FILENAME = "Assignment_02_TweetFile.txt";


        static TweetManager()
        {
            TWEETS = new List<Tweet>(); // initailizing list 

                int counter = 0;

            // Read the file and display it line by line.  
            foreach (string line in File.ReadLines(@"C:\Users\Alisha\source\repos\Assignment02_Alley\Twitterfile\Assignment_02_TweetFile.txt"))
            {
                Console.WriteLine(line);
                TWEETS.Add(Tweet.Parse(line));
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("There were " + counter + " lines");
       

        }

        public static void Initialize()
        {
            TWEETS = new List<Tweet>();
            Tweet twt1 = Tweet.Parse("Bruhhhh \t Kickassalien \t I love youuuu \t #cute");
            Tweet twt2 = Tweet.Parse("Whateva \t Kim \t Where are you going? \t #curious");
            Tweet twt3 = Tweet.Parse("Mazer \t Den \t Have you seen the new star wars? \t #starwars");
            Tweet twt4 = Tweet.Parse("Gangsta \t julli \t Never gonna give you up, never gonna let you down \t #rickroll");
            Tweet twt5 = Tweet.Parse("cloud \t mike \t Happy birthday \t #birthdaywishes");

            TWEETS.Add(twt1);
            TWEETS.Add(twt2);
            TWEETS.Add(twt3);
            TWEETS.Add(twt4);
            TWEETS.Add(twt5);

        }
       
        public static void ShowAll()
        {
            TWEETS = new List<Tweet>();
            foreach (Tweet tweet in TWEETS)
            {
                Console.WriteLine(tweet);              
            }
        }

        public static void ShowAll(string tag)
        {
            Console.WriteLine("Tweet with " + tag + " tag");
            TWEETS = new List<Tweet>();

            foreach (Tweet tweet in TWEETS)
            {
                if (tweet.Tag.ToLower() == tweet.Tag.ToLower())
                {
                    Console.WriteLine(tweet);
                }
            }
        }

    }
}

