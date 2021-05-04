using System;

namespace TemplateMethod
{

    public class ConcreteClass : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("Concrete 1 primitive operation 1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("Concrete 1 primitive operation 2");
        }
    }
}
