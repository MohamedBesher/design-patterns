using System;

namespace State
{

    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(IState state)
        {
            _state = state;
            _state.SetContext(this);
        }

        public void Request1()
        {
            this._state.Handle();
        }
    }
}