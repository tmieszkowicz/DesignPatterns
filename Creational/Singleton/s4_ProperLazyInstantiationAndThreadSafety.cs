namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// This approach uses the Lazy<T> type, which provides:
/// Thread-safe lazy initialization by default (no need for explicit locks).
/// Deferred creation of the instance (created only when Instance is accessed for the first time).
/// Cleaner and more concise code compared to manual double-checked locking.
/// </summary>
sealed class s4_ProperLazyInstantiationAndThreadSafety
{
    public static readonly Lazy<s4_ProperLazyInstantiationAndThreadSafety> _lazyInstance = new(() => new s4_ProperLazyInstantiationAndThreadSafety());
    public static s4_ProperLazyInstantiationAndThreadSafety Instance => _lazyInstance.Value;

    private s4_ProperLazyInstantiationAndThreadSafety()
    {
        Console.WriteLine("Instantiating constructor");
    }
}
