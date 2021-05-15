using System;

namespace BlazorConcepts.Pages.Store
{
    public class FireButtonEvent : IAction
    {
        public DateTime DateTime { get; } = DateTime.UtcNow;
    }
}
