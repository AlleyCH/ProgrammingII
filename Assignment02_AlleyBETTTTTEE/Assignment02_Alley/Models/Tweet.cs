using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Alley.Models
{
    public class Tweet
    {
        private static int CURRENT_ID;

        public string From { get; }

        public string To { get; }

        public string Body { get; }

        public string Tag { get; }

        public string Id { get; }

       public Tweet(string from, string to, string body, string tag)
        {
            from = From;
            to = To;
            body = Body;
            tag = Tag;

            Id = CURRENT_ID.ToString();

            CURRENT_ID ++;
        }

        public Tweet(string from, string to, string body, string tag, string id)
        {
            from = From;
            to = To;
            body = Body;
            tag = Tag;
            id = Id;
        }
            
        public override string ToString()
        {
            return string.Format($" To {0}:\n Body {1}: \n From {2}: Id {3}: tag {4}", 
                To, Body.Substring(0, 40), From, Id, Tag);          
        }

        public static Tweet Parse(string line)
        {
            string[] subString = line.Split(new char[] {'\t'});
           
            return new Tweet(subString[0], subString[1], subString[2], subString[3]);
      



        }

    }
}
