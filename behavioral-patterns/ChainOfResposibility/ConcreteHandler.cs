using System;

namespace ChainOfResposibility
{

    public class ConcreteHandler : BaseHandler
    {
        public override void HandleRequest()
        {

                Console.WriteLine("concrete 1 class Handler ");

            base.HandleRequest();
        }
    }
}
