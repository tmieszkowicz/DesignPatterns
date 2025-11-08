namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// https://sharplab.io/
/// 
/// This approach uses a nested static class to provide lazy initialization.
///
/// The nested class (`Nested`) is not loaded until the Instance property is accessed.
/// When it is loaded, the CLR guarantees thread-safe initialization of its static members.
/// </summary>

sealed class s5_SingletonDesignCoolImplementation
{


    public static string ClassName = string.Empty;
    public s5_SingletonDesignCoolImplementation Instance => Nested.Instance;
    private class Nested
    {
        public static s5_SingletonDesignCoolImplementation Instance { get; } = new();

        static Nested()
        {
        }
    }

    private s5_SingletonDesignCoolImplementation()
    {
        Console.WriteLine("Instantiating constructor");
    }

    static s5_SingletonDesignCoolImplementation()
    {
    }
}
