namespace DesignPatterns.Behavioral.Observer;

public class ScoreUI(Player subject) : IGameObserver
{
    private readonly Player _subject = subject;
    public void Update()
    {
        Console.WriteLine($"Score: {_subject.GetScore()}");
    }
}
