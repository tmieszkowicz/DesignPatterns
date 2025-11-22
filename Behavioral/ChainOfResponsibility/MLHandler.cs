namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class MLHandler : SpamHandler
{
    public override bool HandleSpamCheck(Email email)
    {
        Console.WriteLine("Model checking if email is spam");
        if (email.Body.Length % 2 == 0)
        {
            Console.WriteLine("Email predicted as spam by ML model.");
            return true;
        }

        Console.WriteLine("Email not predicted as spam by ML model.");

        if (_successor is null)
        {
            return false;
        }

        return _successor.HandleSpamCheck(email);
    }
}
