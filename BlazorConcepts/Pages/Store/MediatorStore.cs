using System;
using System.Threading;
using System.Threading.Tasks;
using BlazorConcepts.Pages.Events;
using MediatR;

namespace BlazorConcepts.Pages.Store
{
    public class MediatorStore :
        INotificationHandler<MyNotification>
    {
        private readonly MediatorState _state;

        public MediatorStore(MediatorState state)
        {
            _state = state;
        }

        public Task Handle(MyNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"before {_state.AnotherValue}");
            _state.AnotherValue = notification.Value;
            Console.WriteLine($"after {_state.AnotherValue}");
            return Task.CompletedTask;
        }
    }
}
