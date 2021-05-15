using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Pages.Events
{
    public class AddTableSubBase : ComponentBase, INotificationHandler<MyNotification>
    {
        public int DateTime { get; set; }

        public Task Handle(MyNotification notification, CancellationToken cancellationToken)
        {
            DateTime = notification.Value;
            StateHasChanged();
            return Task.CompletedTask;
        }
    }
}
