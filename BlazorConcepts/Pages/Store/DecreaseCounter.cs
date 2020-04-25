namespace BlazorConcepts.Pages.Store
{
    public class DecreaseCounter : IAction
    {
        public DecreaseCounter(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; }
    }
}
