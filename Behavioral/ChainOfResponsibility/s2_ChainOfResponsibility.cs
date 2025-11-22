namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class s2_ChainOfResponsibility
{
    public static void Run()
    {
        SpamDetectionSystem spamDetectionSystem = new();

        var email = new Email(
            Sender: "spam@spam.com",
            Subject: "Congratulations! You've won a prize",
            Body: "Click here to claim your free prize now!");

        bool isSpam = spamDetectionSystem.CheckForSpam(email);
        Console.WriteLine($"{email} is spam: {isSpam}");
    }
}