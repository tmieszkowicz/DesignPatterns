namespace DesignPatterns.Structural.Facade;

public class s1_Facade()
{
    public void Run()
    {
        var facade = new Facade();
        facade.Operation1();
    }
}

public class Facade()
{
    public void Operation1()
    {
        var class1 = new Class1();
        var class2 = new Class2();
        var class3 = new Class3();
        var class4 = new Class4(class2);

        class4.Operation5(class3);
        class1.Operation2();
        class3.Operation4();
    }
}

public class Class1()
{
    public void Operation2()
    {

    }
}

public class Class2()
{
    public void Operation3()
    {

    }
}
public class Class3()
{
    public void Operation4()
    {

    }
}
public class Class4(Class2 class2)
{
    public void Operation5(Class3 class3)
    {
        class2.Operation3();
        class3.Operation4();
    }
}