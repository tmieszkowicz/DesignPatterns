namespace DesignPatterns.Behavioral.Observer1;

public class s1_Observer
{
    public void Run()
    {
        ConcreteSubject subject = new();

        subject.Attach(new ConcreteObserver(subject));
        subject.Attach(new ConcreteObserver(subject));
        subject.Attach(new ConcreteObserver(subject));
        subject.Attach(new ConcreteObserver(subject));

        subject.SetState("State 1");

        Task.Delay(1000);

        subject.SetState("State 2");
    }
}

public interface Subject
{
    void Attach(Observer observer);
    void Detach(Observer observer);
    void Notify();
}

public class ConcreteSubject : Subject
{
    private readonly List<Observer> _observers = [];
    private string _state = string.Empty;

    public void SetState(string state)
    {
        _state = state;
        Notify();
    }

    public string GetState()
    {
        return _state;
    }

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}

public interface Observer
{
    void Update();
}

public class ConcreteObserver(ConcreteSubject subject) : Observer
{
    private readonly ConcreteSubject _subject = subject;
    public void Update()
    {
        var state = _subject.GetState();
        Console.WriteLine($"Observer notified about the state: {state}");
    }
}

