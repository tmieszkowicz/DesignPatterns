namespace DesignPatterns.Behavioral.Strategy;

public class CreditCardStrategy(
    string name,
    string cardNumber,
    string cvv,
    string dateOfExpiry) : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card: {cardNumber}");
    }
}
