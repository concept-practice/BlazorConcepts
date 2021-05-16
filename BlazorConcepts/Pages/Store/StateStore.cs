using System;
using System.Collections.Generic;

namespace BlazorConcepts.Pages.Store
{
    public class StateStore
    {
        public InitialState State { get; }
        private readonly Dictionary<Type, Action<IAction>> _reducers;

        public StateStore()
        {
            State = new InitialState
            {
                Value = 0
            };

            _reducers = new Dictionary<Type, Action<IAction>>
            {
                { typeof(IncreaseCounter), action => State.Value += ((IncreaseCounter) action).Amount},
                { typeof(DecreaseCounter), action => State.Value -= ((DecreaseCounter) action).Amount},
                { typeof(FireButtonEvent), action => EventHandler?.Invoke(this, action as FireButtonEvent)},
            };
        }

        public void Dispatch(IAction action)
        {
            _reducers[action.GetType()].Invoke(action);
        }

        public event EventHandler<FireButtonEvent> EventHandler;
    }
}
