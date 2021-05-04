using System;

namespace State
{

    public interface IState
    {
        void Handle();
        void SetContext(Context Context);

    }
}