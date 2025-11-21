namespace DesignPatterns.Behavioral.Mediator;

public class RegularUser(string name) : User(name)
{
    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"{Name} receives from {senderName}: {message}");
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} send: {message}");
        _mediator.Notify(this, message);
    }
}
