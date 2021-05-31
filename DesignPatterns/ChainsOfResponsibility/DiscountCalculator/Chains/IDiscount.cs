namespace DesignPatterns
{
    public interface IDiscount
    {
        IDiscount Next { get; set; }
        double Discounts(Budget budget);
    }

}
