using System;

namespace ChainOfResposibility
{
    public class BaseHandler : IHandler
    {
        protected IHandler next;
        public void SetNext(IHandler handler)
        {
            next = handler;
        }
        public virtual void HandleRequest(string handlerSelector)
        {
            if (next != null)
            {
                next.HandleRequest(handlerSelector);
            }
            Console.WriteLine("Base class Handler");
        }
    }




}
