using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumericTypes2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            int milesDriven;
            int gasGallons;
            float milesPerGallon;

            Console.WriteLine("How many miles have you driven?");
            input = Console.ReadLine();
            milesDriven = int.Parse(input);

            Console.WriteLine("How many gallons of gas have you used?");
            input = Console.ReadLine();
            gasGallons = int.Parse(input);

            milesPerGallon = milesDriven / gasGallons;
            Console.WriteLine("Your MPG is: " + milesPerGallon.ToString());
            Console.ReadLine();
        }
    }
}
