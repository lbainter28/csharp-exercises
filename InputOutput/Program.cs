using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputOutput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Tell us your name:");
            input = Console.ReadLine();

            Console.WriteLine("Hello, " + input + "!");
            Console.ReadLine();
        }
    }
}
