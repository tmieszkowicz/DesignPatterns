namespace DesignPatterns.Behavioral.Strategy;

public class PayPalStrategy(string email, string password) : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal: {email}");
    }
}
