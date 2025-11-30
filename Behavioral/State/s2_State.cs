namespace DesignPatterns.Behavioral.State;


public class s2_State
{
    public void Run()
    {
        Character hero = new(); // normal state

        Console.WriteLine($"Initial health: {hero.Health}");

        hero.TakeDamage(30);
        Console.WriteLine($"Health after damage: {hero.Health}");

        hero.CollectPowerUp();
        Console.WriteLine($"Health after power-up: {hero.Health}, has power up: {hero.HasPowerUp}");

        hero.TakeDamage(30);
        Console.WriteLine($"Health after damage: {hero.Health}, has power up: {hero.HasPowerUp}");

        for (int i = 0; i < 12; i++)
        {
            hero.Update();
        }

        Console.WriteLine($"Health after 12 ticks: {hero.Health}, has power up: {hero.HasPowerUp}");

        hero.TakeDamage(70);
        Console.WriteLine($"Health after damage: {hero.Health}");
    }
}
