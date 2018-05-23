using System;

namespace CroweHealth
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World";

            HelloWorld hw = new HelloWorld();
            hw.CreateHelloWorld(hello);
            Console.ReadLine();
        }
    }
}
