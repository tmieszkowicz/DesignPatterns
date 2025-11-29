namespace DesignPatterns.Behavioral.Observer;

public class HealthBarUI(Player subject) : IGameObserver
{
    private readonly Player _subject = subject;
    public void Update()
    {
        Console.WriteLine($"Health: {_subject.GetHealth()}");
    }
}
