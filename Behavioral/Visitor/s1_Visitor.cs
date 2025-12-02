namespace DesignPatterns.Behavioral.Visitor1;

public class s1_Visitor()
{
    public void Run()
    {
        Element element1 = new ConcreteElement1();
        Element element2 = new ConcreteElement2();

        Visitor visitor1 = new ConcreteVisitor1();
        Visitor visitor2 = new ConcreteVisitor2();

        element1.Accept(visitor1);
        element2.Accept(visitor1);

        element1.Accept(visitor2);
        element2.Accept(visitor2);
    }
}

public interface Element
{
    void Accept(Visitor visitor);
}

public class ConcreteElement1 : Element
{
    public void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }

    public string Operation1()
    {
        return "concrete element 1";
    }
}

public class ConcreteElement2 : Element
{
    public void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }

    public string Operation2()
    {
        return "concrete element 2";
    }
}

public interface Visitor
{
    void Visit(ConcreteElement1 element);
    void Visit(ConcreteElement2 element);
}

public class ConcreteVisitor1 : Visitor
{
    public void Visit(ConcreteElement1 element)
    {
        var message = element.Operation1();
        Console.WriteLine($"Concrete visitor 1: {message}");
    }

    public void Visit(ConcreteElement2 element)
    {
        var message = element.Operation2();
        Console.WriteLine($"Concrete visitor 1: {message}");
    }
}

public class ConcreteVisitor2 : Visitor
{
    public void Visit(ConcreteElement1 element)
    {
        var message = element.Operation1();
        Console.WriteLine($"Concrete visitor 2: {message}");
    }

    public void Visit(ConcreteElement2 element)
    {
        var message = element.Operation2();
        Console.WriteLine($"Concrete visitor 2: {message}");
    }
}
