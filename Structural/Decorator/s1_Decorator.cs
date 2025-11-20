
namespace DesignPatterns.Structural.Decorator1;

public class s1_Decorator()
{
    public void Run()
    {
        Component component = new ConcreteDecorator2(
            component: new ConcreteDecorator1(
                component: new ConcreteDecorator1(
                    component: new ConcreteComponent())));

        component.Operation();
    }
}

class ConcreteComponent : Component
{
    public void Operation()
    {
        Console.WriteLine("ConcreteComponent");
    }
}

public interface Component
{
    void Operation();
}

public abstract class Decorator(Component component) : Component
{
    protected Component _component = component;

    public virtual void Operation()
    {
        _component.Operation();
    }
}

public class ConcreteDecorator1(Component component) : Decorator(component)
{
    public override void Operation()
    {
        Console.WriteLine("-----ConcreteDecorator1-----");
        _component.Operation();
        Console.WriteLine("-----ConcreteDecorator1-----");
    }
}

public class ConcreteDecorator2(Component component) : Decorator(component)
{
    public override void Operation()
    {
        Console.WriteLine("-----ConcreteDecorator2-----");
        _component.Operation();
        Console.WriteLine("-----ConcreteDecorator2-----");
    }
}
