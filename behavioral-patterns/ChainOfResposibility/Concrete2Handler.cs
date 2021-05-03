using System;

namespace ChainOfResposibility
{


    public class Concrete2Handler : BaseHandler
    {
        public override void HandleRequest()
        {
         
                Console.WriteLine("concrete 2 class Handler ");


                base.HandleRequest();
            
        }
    }




}
