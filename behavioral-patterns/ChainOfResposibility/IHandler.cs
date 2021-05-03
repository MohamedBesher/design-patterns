using System;

namespace ChainOfResposibility
{

    public interface IHandler
    {
        void HandleRequest(string handlerSelector);
    }




}
