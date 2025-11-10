// a concrete class that creates a concrete instance from a set of defined classes
// using inheritance or interface implementation
class PasswordFactory2
{
    public IPassword Generate(ushort length/* .. */)
    {
        // some complex logic
        return length < 8
            ? new SimplePassword()
            : new ComplexPassword();
    }
}

interface IPassword { }
class SimplePassword : IPassword { }
class ComplexPassword : IPassword { }

// a concrete class that creates a concrete class
class PasswordFactory
{
    public static Password Generate(/* .. */)
    {
        // some complex logic
        return new Password();
    }
}

// a static factory method - a static method defined in a concrete type that creates that type
class Password
{
    public Password() { }

    public static Password Generate(/* .. */)
    {
        // some complex logic
        return new Password();
    }
}