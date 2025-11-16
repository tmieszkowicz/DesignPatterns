namespace Structural.Bridge;

public class s1_Bridge()
{
    public void Run()
    {
        Abstraction abstraction = new RefinedAbstraction1(new ConcreteImplementor1());

        abstraction.Foo();
    }
}

public abstract class Abstraction(Implementor implementor)
{
    public Implementor Implementor { get; init; } = implementor;
    public abstract void Foo();
}

public class RefinedAbstraction1(Implementor implementor) : Abstraction(implementor)
{
    public override void Foo()
    {
        Implementor.Print();
    }
}

public class RefinedAbstraction2(Implementor implementor) : Abstraction(implementor)
{
    public override void Foo()
    {
        Console.WriteLine("-----");
        Implementor.Print();
        Console.WriteLine("-----");
    }
}

public interface Implementor
{
    void Print();
}

public class ConcreteImplementor1() : Implementor
{
    public void Print()
    {
        Console.WriteLine("Hello from ConcreteImplementor1");
    }
}

public class ConcreteImplementor2() : Implementor
{
    public void Print()
    {
        Console.WriteLine("Hello from ConcreteImplementor2");
    }
}