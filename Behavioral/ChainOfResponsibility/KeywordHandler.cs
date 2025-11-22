namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class KeywordHandler : SpamHandler
{
    public override bool HandleSpamCheck(Email email)
    {
        Console.WriteLine("KeywordHandler checking email for spam keywords.");
        if (ContainsSpamKeywords(email.Subject) || ContainsSpamKeywords(email.Body))
        {
            Console.WriteLine("Spam detected by KeywordHandler.");
            return true;
        }

        Console.WriteLine("No spam detected by KeywordHandler.");

        if (_successor is null)
        {
            return false;
        }

        return _successor.HandleSpamCheck(email);
    }

    private bool ContainsSpamKeywords(string text)
    {
        return text.Contains("Buy now") || text.Contains("Free") || text.Contains("Click here");
    }
}
