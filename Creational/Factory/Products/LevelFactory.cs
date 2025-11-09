// simple factory for creating a level
public static class LevelFactory
{
    public static Level CreateLevel(int levelType)
    {
        return levelType switch
        {
            1 => new CaveLevel(),
            2 => new HauntedHouseLevel(),
            _ => throw new ArgumentException("Invalid level type"),
        };
    }
}