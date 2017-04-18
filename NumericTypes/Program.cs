using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumericTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            int length;
            int width;
            int area;

            Console.WriteLine("What is the rectangle's length?");
            input = Console.ReadLine();
            length = int.Parse(input);

            Console.WriteLine("What is the rectangle's width?");
            input = Console.ReadLine();
            width = int.Parse(input);

            area = length * width;
            Console.WriteLine("The rectangle's area is: " + area.ToString());
            Console.ReadLine();
        }
    }
}
