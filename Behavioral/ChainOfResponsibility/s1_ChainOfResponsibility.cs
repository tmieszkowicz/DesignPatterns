namespace DesignPatterns.Behavioral.ChainOfResponsibility1;

public class s1_ChainOfResponsibility()
{
    public void Run()
    {
        Handler handler1 = new ConcreteHandler1();
        Handler handler2 = new ConcreteHandler2();
        Handler handler3 = new ConcreteHandler3();

        handler1.SetSuccessor(handler2);
        handler2.SetSuccessor(handler3);

        string[] requests = { "1", "2", "3", "4" };

        foreach (var request in requests)
        {
            handler1.Handle(request);
        }
    }
}

public abstract class Handler()
{
    protected Handler? _successor;

    public void SetSuccessor(Handler successor)
    {
        _successor = successor;
    }

    public abstract void Handle(string request);
}

public class ConcreteHandler1 : Handler
{
    public override void Handle(string request)
    {
        if (request == "1")
        {
            Console.WriteLine("ConcreteHandler1 handled the request.");
            return;
        }

        if (_successor is null)
        {
            return;
        }

        _successor.Handle(request);
    }
}

public class ConcreteHandler2 : Handler
{
    public override void Handle(string request)
    {
        if (request == "2")
        {
            Console.WriteLine("ConcreteHandler2 handled the request.");
            return;
        }

        if (_successor is null)
        {
            return;
        }

        _successor.Handle(request);
    }
}

public class ConcreteHandler3 : Handler
{
    public override void Handle(string request)
    {
        if (request == "3")
        {
            Console.WriteLine("ConcreteHandler3 handled the request.");
            return;
        }

        if (_successor is null)
        {
            return;
        }

        _successor.Handle(request);
    }
}
