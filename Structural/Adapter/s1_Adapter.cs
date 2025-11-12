namespace Structural.Adapter;

public class s1_Adapter
{
    public void Run()
    {
        ITarget target = new Adapter(new Adaptee());
        target.Request();
    }
}

interface ITarget
{
    void Request();
}

public class Adapter(Adaptee adaptee) : ITarget
{
    public void Request()
    {
        adaptee.SpecificRequest();
    }
}

public class Adaptee()
{
    public void SpecificRequest()
    {
        // Specific behavior
    }
}