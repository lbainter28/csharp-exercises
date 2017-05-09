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
            Student bono1 = new Student("Paul David Hewson", 4);
            Student bono2 = new Student("Bono", 4);
            if (bono1.equals(bono2))
            {
                Console.WriteLine(bono1.getName() +
                    "is the same as" + bono2.getName());
            }
        }

    }
}
