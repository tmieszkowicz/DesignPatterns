
namespace DesignPatterns.Behavioral.Mediator;

public class AdminUser(string user) : User(user)
{
    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"Admin {Name} receives from {senderName}: {message}");
    }

    public override void Send(string message)
    {
        Console.WriteLine($"Admin {Name} announces: {message}");
        _mediator.Notify(this, $"ADMIN MESSAGE: {message}");
    }

    internal void BroadcastAlert(string alert)
    {
        Console.WriteLine($"Admin {Name} broadcasts alert: {alert}");
        _mediator.Notify(this, $"ALERT: {alert}");
    }
}
