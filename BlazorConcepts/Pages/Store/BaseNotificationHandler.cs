using System;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Pages.Store
{
    public abstract class BaseNotificationHandler<TStore, TEvent> : ComponentBase, IDisposable
        where TStore : IEvent<TEvent>
    {
        [CascadingParameter]
        public TStore StateStore { get; set; }

        protected override void OnInitialized()
        {
            StateStore.EventHandler += HandleEvent;
            StateStore.EventHandler += UpdateState;
            base.OnInitialized();
        }

        public abstract void HandleEvent(object sender, TEvent notification);

        public void Dispose()
        {
            StateStore.EventHandler -= HandleEvent;
            StateStore.EventHandler -= UpdateState;
        }

        private void UpdateState(object sender, TEvent notification)
        {
            StateHasChanged();
        }
    }
}
