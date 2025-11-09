namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// This isn't the best approach as the Instance property will be initialized with eager initialization.
/// The instance will be created as soon as the class is loaded, even if it's never used.
/// </summary>
sealed class s1_NaiveSingleton
{
    public static s1_NaiveSingleton Instance { get; } = new();

    private s1_NaiveSingleton()
    {
    }
}
