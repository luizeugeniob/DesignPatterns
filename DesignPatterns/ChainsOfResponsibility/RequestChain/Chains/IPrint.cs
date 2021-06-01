namespace DesignPatterns
{
    public interface IPrint
    {
        IPrint Next { get; set; }
        void Print(Request request, BankAccount bankAccount);
    }
}
