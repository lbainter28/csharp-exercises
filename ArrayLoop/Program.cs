using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayLoop
{
    public class ArrayLoop
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 1, 2, 3, 5, 8 };

            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
