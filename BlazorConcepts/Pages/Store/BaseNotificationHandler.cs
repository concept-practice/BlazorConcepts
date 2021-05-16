using System;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Pages.Store
{
    public abstract class BaseNotificationHandler<TEvent> : ComponentBase, IDisposable
        where TEvent : IAction
    {
        [CascadingParameter]
        public StateStore StateStore { get; set; }

        protected virtual void HandleEvent(object sender, TEvent notification)
        {
            UpdateState(sender, notification);
        }

        public abstract void Dispose();

        protected void UpdateState(object sender, TEvent notification)
        {
            StateHasChanged();
        }
    }
}
