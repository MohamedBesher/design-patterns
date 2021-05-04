using System;

namespace State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stateA = new ConcreteStateA();
            var context = new Context(stateA);
            context.Request1();
            context.Request1();
            Console.WriteLine("Hello World!");
        }
    }
}