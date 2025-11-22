namespace DesignPatterns.Behavioral.Strategy;

public class BankTransferStrategy(string bankName, string bankAccount) : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using Bank Account: {bankAccount}");
    }
}