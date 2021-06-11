namespace DesignPatterns
{
    public interface IBudgetState
    {
        void ApplyExtraDiscount(Budget budget);
        void Approves(Budget budget);
        void Disapprove(Budget budget);
        void Finalize(Budget budget);
    }
}
