using System;

namespace BlazorConcepts.Pages.Store
{
    public interface IStore<TEvent> where TEvent : IAction
    {
        event EventHandler<TEvent> EventHandler;
    }
}
