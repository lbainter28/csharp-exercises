using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class HelloWorld
    {

        private string Message = "Hello World";

        public HelloWorld(string message)
        {
            Message = message;
        }

        public void SayHello()
        {
            Console.WriteLine(Message);
        }
    }
}
