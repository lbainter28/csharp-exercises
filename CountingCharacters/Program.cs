using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string testString = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            char[] charArray = testString.ToLower().ToCharArray();

            Dictionary<char, int> charCount =
                new Dictionary<char, int>();

            foreach (char c in charArray)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            Console.WriteLine("Character Count:");
            foreach (KeyValuePair<char, int> kv in charCount.OrderBy(c => c.Key))
            {
                Console.WriteLine(kv.Key + ":" + kv.Value.ToString());
            }
            Console.ReadLine();
        }

    }
}
