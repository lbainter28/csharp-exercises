using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsAndStrings
{
    public class ListsAndStrings
    {
        public static void Main(string[] args)
        {
            List<string> strList = new List<string>() { "cat", "chinchilla", "sheep", "zebra", "horse", "giraffe", "aadvark", "jaguar" };
            List<string> fiveCharWords = GetWords(strList);
            for (int i = 0; i < fiveCharWords.Count; i++)
            {
                Console.WriteLine(fiveCharWords[i]);
            }
            Console.ReadLine();
        }

        public static List<string> GetWords(List<string> strList)
        {
            List<string> fiveCharList = new List<string>();

            foreach (string str in strList)
            {
                if (str.ToCharArray().Count() == 5)
                {
                    fiveCharList.Add(str);
                }
            }
            return fiveCharList;
        }
    }
}
