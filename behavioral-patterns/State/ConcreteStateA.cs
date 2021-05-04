using System;

namespace State
{

    public class ConcreteStateA : BaseState
    {
        public override void Handle()
        {
            Console.WriteLine("ConcreteState A Handle method");
            _context.TransitionTo(new ConcreteStateB());
        }
    }
}