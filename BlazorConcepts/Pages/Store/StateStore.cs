using System;
using System.Collections.Generic;
using System.Linq;
using BlazorConcepts.Pages.Events;

namespace BlazorConcepts.Pages.Store
{
    public class StateStore
    {
        public InitialState State { get; }
        private readonly Dictionary<Type, Action<IAction>> _reducers;

        private readonly List<EventHandler<IAction>> _eventHandlers;

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
                { typeof(FireButtonEvent), action => FireButtonHandler?.Invoke(this, action as FireButtonEvent)},
            };
        }

        public void Dispatch(IAction action)
        {
            _reducers[action.GetType()].Invoke(action);
        }

        public event EventHandler<FireButtonEvent> FireButtonHandler;

        public void AddHandler<TAction>(EventHandler<IAction> handler) where TAction : IAction
        {
            _eventHandlers.Add(handler);
        }

        public EventHandler<IAction> GetHandler<TAction>() where TAction : IAction
        {
            return _eventHandlers.First(x => x.GetType().GetGenericArguments().Any(x => x.GetType() == ))
        }
    }
}
