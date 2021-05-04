using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var abstractClass = new ConcreteClass();
            abstractClass.TemplateMethod();

            Concrete2Class concrete2Class = new Concrete2Class();
            concrete2Class.TemplateMethod();
        }
    }
}
