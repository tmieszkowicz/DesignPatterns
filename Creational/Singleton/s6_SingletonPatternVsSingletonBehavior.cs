namespace DesignPatterns.Creational.Singleton;

/// Demonstrates registering a service as a singleton in the built-in DI container.
///
/// Important distinction:
/// - This uses the DI concept of a "singleton" service,
/// - This is not the same as the Singleton design pattern:
///     1. No guarantee of a single instance globally (only within the DI container).
///     2. No global access point – instance resolution always goes through the container.
///     3. No direct control over initialization – the container manages creation.
class s6_SingletonPatternVsSingletonBehavior
{
    private readonly IServiceCollection _services = new ServiceCollection();
    public s6_SingletonPatternVsSingletonBehavior()
    {
        _services.AddSingleton<Logger>();

        var serviceProvider = _services.BuildServiceProvider();

        var logger1 = serviceProvider.GetRequiredService<Logger>();
        var logger2 = serviceProvider.GetRequiredService<Logger>();
        var logger3 = serviceProvider.GetRequiredService<Logger>();
    }
}
/// <summary>
/// This class does not implement the Singleton design pattern.
/// Reasons:
/// 1. No mechanism to enforce a single global instance.
/// 2. No easy global access (must be resolved through DI container).
/// 3. No control over when or how the instance is created.
class Logger { }