using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Area
{
    public class Area
    {
        public static void Main(string[] args)
        {
            double pi = 3.14;
            string input;
            float radius;
            double area;

            do
            {
                Console.WriteLine("Enter a radius:");
                input = Console.ReadLine();
                radius = float.Parse(input);
            
                if (radius <= 0)
                {
                    Console.WriteLine("Error: Please enter a valid radius");
                    Console.ReadLine();
                }
                else
                {
                    area = pi * radius * radius;
                    Console.WriteLine("The area of your circle is: " + area.ToString());
                    Console.ReadLine();
                }
            } while (radius <= 0);
        }
    }
}
