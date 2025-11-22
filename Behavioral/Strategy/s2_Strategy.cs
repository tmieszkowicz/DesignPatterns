namespace DesignPatterns.Behavioral.Strategy;

public class s2_Strategy
{
    public void Run()
    {
        ShoppingCart context = new();

        context.SetStrategy(new CreditCardStrategy(
            name: "John Doe",
            cardNumber: "1234567890123456",
            cvv: "123",
            dateOfExpiry: "12/25"));

        context.Checkout(100.0m);

        context.SetStrategy(new PayPalStrategy(
            email: "john@doe.com",
            password: "password123"));

        context.Checkout(200.0m);

        context.SetStrategy(new BankTransferStrategy(
            bankName: "MyBank",
            bankAccount: "9876543210"));

        context.Checkout(300.0m);
    }
}