using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student laurie = new Student("Laurie", 54);
            laurie.AddGrade(3, 4);
            laurie.AddGrade(4, 3);
            Console.WriteLine(
                "Credits: {0}, GPA: {1}",
                laurie.NumberOfCredits,
                laurie.Gpa
            );
            Console.ReadLine();
        }
    }
}
