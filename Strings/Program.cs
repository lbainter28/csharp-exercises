using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string alicePassage;
            string input;
            bool inputPresent;

            alicePassage = @"Alice was beginning to get very 
                             tired of sitting by her sister on 
                             the bank, and of having nothing to do: 
                             once or twice she had peeped into the book 
                             her sister was reading, but it had no pictures 
                             or conversations in it, 'and what is the use of 
                             a book,' thought Alice 'without pictures or 
                             conversation?".ToLower();

            Console.WriteLine("What should we search for?");
            input = Console.ReadLine().Trim().ToLower();
            inputPresent = alicePassage.IndexOf(input) > -1;
            Console.WriteLine(inputPresent);
            Console.ReadLine();


        }
    }
}
