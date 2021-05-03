using System;

namespace ChainOfResposibility
{


    public class Concrete2Handler : BaseHandler
    {
        public override void HandleRequest(string handlerSelector)
        {
            if (handlerSelector == "2")
            {
                Console.WriteLine("concrete 2 class Handler ");
            }
            else
            {
                base.HandleRequest(handlerSelector);
            }
        }
    }




}
