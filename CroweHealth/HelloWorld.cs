using System;
using HelloWorld.Contracts;

namespace CroweHealth
{
    public class HelloWorld : IHelloWorld
    {
        public string CreateHelloWorld(string hello)
        {
            return hello;
        }
    }
}
