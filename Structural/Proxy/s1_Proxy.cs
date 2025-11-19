namespace DesignPatterns.Structural.Proxy1;

public class s1_Proxy()
{
    public void Run()
    {
        Proxy proxy = new Proxy();
        proxy.Operation();
    }
}

public interface Subject
{
    void Operation();
}

public class Proxy : Subject
{
    private RealSubject? _realSubject = null;

    public Proxy()
    {
        Console.WriteLine("Instantiating Proxy");
    }

    public void Operation()
    {
        Console.WriteLine("Proxy Operation");

        if (_realSubject == null)
        {
            Console.WriteLine("Real subject is null, creating it now.");
            _realSubject = new RealSubject();
        }

        Console.WriteLine("Logging before calling RealSubject.Operation()");
        _realSubject.Operation();
        Console.WriteLine("Logging after calling RealSubject.Operation()");
    }
}

public class RealSubject : Subject
{
    public RealSubject()
    {
        Console.WriteLine("Instantiating RealSubject");
    }
    public void Operation()
    {
        Console.WriteLine("RealSubject Operation");
    }
}
