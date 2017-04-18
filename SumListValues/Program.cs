using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumListValues
{
    public class SumListValues
    {
        public static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(SumListValues.GetSum(numList));
            Console.ReadLine();
        }

        public static string GetSum(List<int> numList)
        {
            int numSum = 0;
            foreach (int num in numList)
            {
                if (num % 2 == 0)
                    numSum += num;
            }
            return numSum.ToString();
        }
    }
}
