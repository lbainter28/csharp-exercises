using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HelloWorld goodbye = new HelloWorld("Goodbye World");
            goodbye.SayHello();
        }
    }
}
