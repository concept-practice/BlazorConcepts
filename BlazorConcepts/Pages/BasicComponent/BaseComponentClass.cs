using Microsoft.AspNetCore.Components;

namespace BlazorConcepts.Pages.BasicComponent
{
    public class BaseComponentClass : ComponentBase
    {
        public string Message { get; set; } = "I got this from my base class!";
    }
}
