namespace DesignPatterns.Behavioral.TemplateMethod1;

public class s1_TempleMethod
{
    public void Run()
    {
        AbstractClass instance1 = new ConcreteClass1();
        instance1.TemplateMethod();

        AbstractClass instance2 = new ConcreteClass2();
        instance2.TemplateMethod();
    }
}

public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Console.WriteLine("Before operation 1");
        PrimitiveOperation1();

        Console.WriteLine("Before operation 2");
        PrimitiveOperation2();

        Console.WriteLine("Before hook");
        Hook();
    }

    protected abstract void PrimitiveOperation1();
    protected abstract void PrimitiveOperation2();

    public virtual void Hook()
    {
        Console.WriteLine("Hook invoked.");
    }
}

public class ConcreteClass1 : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine("Primitive operation 1 invoked.");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("Primitive operation 2 invoked.");
    }
}

public class ConcreteClass2 : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine("Primitive operation 1 called.");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("Primitive operation 2 called.");
    }

    public override void Hook()
    {
        Console.WriteLine("Hook called in ConcreteClass2.");
    }
}
