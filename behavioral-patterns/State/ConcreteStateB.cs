using System;

namespace State
{

    public class ConcreteStateB : BaseState
    {
        public override void Handle()
        {
            Console.WriteLine("ConcreteState B Handle method");
        }
    }
}