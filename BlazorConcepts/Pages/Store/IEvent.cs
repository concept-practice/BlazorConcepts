using System;

namespace BlazorConcepts.Pages.Store
{
    public interface IEvent<TEvent>
    {
        event EventHandler<TEvent> EventHandler;
    }
}
