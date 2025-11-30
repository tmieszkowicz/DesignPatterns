namespace DesignPatterns.Behavioral.State1;

public class s1_State
{
    public void Run()
    {
        Context context = new(new ConcreteStateA());

        context.Request(); // state A
        context.Request(); // state B
        context.Request(); // state A
    }
}

public class Context(State initialState)
{
    private State _state = initialState;

    public void SetState(State state)
    {
        _state = state;
    }

    public void Request()
    {
        _state.Handle(this);
    }
}

public interface State
{
    void Handle(Context context);
}

public class ConcreteStateA : State
{
    public void Handle(Context context)
    {
        Console.WriteLine("State A handling request.");
        context.SetState(new ConcreteStateB());
    }
}

public class ConcreteStateB : State
{
    public void Handle(Context context)
    {
        Console.WriteLine("State B handling request.");
        context.SetState(new ConcreteStateA());
    }
}
