namespace DesignPatterns.Behavioral.Mediator1;

public class s1_Mediator()
{
    public void Run()
    {
        Colleague1 colleague1 = new();
        Colleague2 colleague2 = new();
        ConcreteMediator mediator = new(colleague1, colleague2);

        colleague1.Operation1();
        colleague2.Operation2();
    }
}

public interface Mediator
{
    void Notify(Colleague sender, string @event);
}

public class ConcreteMediator : Mediator
{
    private readonly Colleague1 _colleague1;
    private readonly Colleague2 _colleague2;

    public ConcreteMediator(Colleague1 colleague1, Colleague2 colleague2)
    {
        _colleague1 = colleague1;
        _colleague1.SetMediator(this);

        _colleague2 = colleague2;
        _colleague2.SetMediator(this);
    }

    public void Notify(Colleague sender, string @event)
    {
        Console.WriteLine($"Concrete mediator notfiedi by {sender.GetType().Name} about {@event}");

        if (sender == _colleague1)
        {
            //call some method on collegue 2
            _colleague2.Receive(@event);
        }
        else if (sender == _colleague2)
        {
            //call some method on collegue 1
            _colleague1.Receive(@event);
        }
    }
}

public abstract class Colleague
{
    protected Mediator _mediator = null!;

    public void SetMediator(Mediator mediator)
    {
        _mediator = mediator;
    }
}

public class Colleague1 : Colleague
{
    public void Operation1()
    {
        Console.WriteLine("Colleague1 does Operation1.");
        _mediator.Notify(this, "Operation1");
    }

    public void Receive(string @event)
    {
        Console.WriteLine($"Colleague1 received {@event}.");
    }
}

public class Colleague2 : Colleague
{
    public void Operation2()
    {
        Console.WriteLine("Colleague2 does Operation2.");
        _mediator.Notify(this, "Operation2");
    }

    public void Receive(string @event)
    {
        Console.WriteLine($"Colleague2 received {@event}.");
    }
}
