using System;

namespace BlazorConcepts.Pages.Store
{
    public interface IEvent<TEvent> where TEvent : IAction
    {
        event EventHandler<TEvent> EventHandler;
    }
}
