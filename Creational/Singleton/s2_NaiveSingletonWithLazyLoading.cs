namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// Better approach as we are introducing lazy loading.
/// But this is not thread safe.
///
/// In a multithreaded environment, multiple threads could enter the 'if (_instance is null)' block simultaneously,
/// resulting in multiple instances being created.
/// </summary>
sealed class s2_NaiveSingletonWithLazyLoading
{

    public static s2_NaiveSingletonWithLazyLoading _instance = default!;
    public static s2_NaiveSingletonWithLazyLoading Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new s2_NaiveSingletonWithLazyLoading();
            }

            return _instance;
        }
    }

    private s2_NaiveSingletonWithLazyLoading()
    {
        Console.WriteLine("Instantiating constructor");
    }
}
