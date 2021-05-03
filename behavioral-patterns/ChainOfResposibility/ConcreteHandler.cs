using System;

namespace ChainOfResposibility
{

    public class ConcreteHandler : BaseHandler
    {
        public override void HandleRequest(string handlerSelector)
        {
            if (handlerSelector == "1")
            {
                Console.WriteLine("concrete 1 class Handler ");
            }
            else
            {
                base.HandleRequest(handlerSelector);
            }
        }
    }




}
