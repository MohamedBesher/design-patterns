using System;

namespace ChainOfResposibility
{
    class Program
    {
        static void Main(string[] args)
        {
            #region chainOfResposibility
            var concrete1 = new ConcreteHandler();
            var concrete2 = new Concrete2Handler();

            concrete1.SetNext(concrete2);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.

            concrete1.HandleRequest();
            //concrete1.HandleRequest("2");

            #endregion


            Console.ReadLine();

        }
    }




}
