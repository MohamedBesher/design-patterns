using System;

namespace TemplateMethod
{
    public class Concrete2Class : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("Concrete 2 primitive operation 1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("Concrete 2 primitive operation 2");
        }
    }
}
