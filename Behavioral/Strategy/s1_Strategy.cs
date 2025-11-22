namespace DesignPatterns.Behavioral.Strategy1;

public class s1_Strategy
{
    public void Run()
    {
        Context context = new Context();

        context.SetStrategy(new ConcreteStrategyA());
        context.ExecuteStrategy();

        context.SetStrategy(new ConcreteStrategyB());
        context.ExecuteStrategy();

        context.SetStrategy(new ConcreteStrategyC());
        context.ExecuteStrategy();
    }
}

public class Context()
{
    private Strategy? _strategy;

    public void SetStrategy(Strategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy?.Execute();
    }

}

public interface Strategy
{
    void Execute();
}

public class ConcreteStrategyA : Strategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy A executed");
    }
}

public class ConcreteStrategyB : Strategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy B executed");
    }
}

public class ConcreteStrategyC : Strategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy C executed");
    }
}