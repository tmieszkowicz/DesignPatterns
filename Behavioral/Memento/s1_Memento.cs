namespace DesignPatterns.Memento1;

public class s1_Memento
{
    public void Run()
    {
        Originator originator = new();
        CareTaker careTaker = new();

        originator.SetState("State 1");
        careTaker.AddMemento(originator.CreateMemento());

        originator.SetState("State 2");
        careTaker.AddMemento(originator.CreateMemento());

        originator.SetState("State 3");
        careTaker.AddMemento(originator.CreateMemento());

        originator.SetState("State 4");
        careTaker.AddMemento(originator.CreateMemento());


        originator.Restore(careTaker.GetMemento(0));
        Console.WriteLine(originator.GetState());

        originator.Restore(careTaker.GetMemento(1));
        Console.WriteLine(originator.GetState());
    }
}

public class Originator
{
    private string _state = string.Empty;

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }
    public Memento CreateMemento()
    {
        return new Memento(_state);
    }

    public void Restore(Memento memento)
    {
        _state = memento.GetState();
    }
    public class Memento
    {
        private readonly string _state;

        internal Memento(string state)
        {
            _state = state;
        }

        internal string GetState()
        {
            return _state;
        }

    }
}

public class CareTaker
{
    private readonly List<Originator.Memento> _mementos = [];

    public void AddMemento(Originator.Memento memento)
    {
        _mementos.Add(memento);
    }

    public Originator.Memento GetMemento(int index)
    {
        return _mementos[index];
    }
}
