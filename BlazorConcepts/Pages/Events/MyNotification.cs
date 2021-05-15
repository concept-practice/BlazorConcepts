using MediatR;

namespace BlazorConcepts.Pages.Events
{
    public class MyNotification : INotification
    {
        public MyNotification(int value)
        {
            Value = value;
        }

        public int Value { get;  }
    }
}
