namespace DesignPatterns.Behavioral.Observer;

public class s1_Observer
{
    public void Run()
    {
        Player player = new();

        player.Attach(new GameOverScreen(player));
        player.Attach(new HealthBarUI(player));
        player.Attach(new ScoreUI(player));

        player.SetState(health: 100, score: 0);
        player.SetState(health: 100, score: 10);
        player.SetState(health: 80, score: 10);
        player.SetState(health: 0, score: 10);
    }
}
