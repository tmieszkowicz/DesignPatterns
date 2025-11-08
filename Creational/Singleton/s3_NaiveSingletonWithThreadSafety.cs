namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// This approach uses locking to ensure thread safety while lazily initializing the instance.
///
/// The current code locks every time Instance is accessed when _instance is null.
/// This is expensive  and can cause latency if Instance is frequently accessed.
///
/// Solution: Double-Checked Locking
/// This ensures that locking happens only during the first initialization, making subsequent calls efficient.
/// </summary>
sealed class s3_NaiveSingletonWithThreadSafety
{

    public static s3_NaiveSingletonWithThreadSafety _instance = default!;
    public static object _lock = new();
    public static s3_NaiveSingletonWithThreadSafety Instance
    {
        get
        {
            if (_instance is null)
            {
                Console.WriteLine("Locking..");
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new s3_NaiveSingletonWithThreadSafety();
                    }
                }
            }
            return _instance;
        }
    }

    private s3_NaiveSingletonWithThreadSafety()
    {
        Console.WriteLine("Instantiating constructor");
    }
}