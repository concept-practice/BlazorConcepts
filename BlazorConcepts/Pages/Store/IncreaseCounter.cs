namespace BlazorConcepts.Pages.Store
{
    public class IncreaseCounter : IAction
    {
        public IncreaseCounter(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; }
    }
}
