public class CaveLevel : Level
{
    public override IEnemy EncounterEnemy()
    {
        return new Goblin();
    }
}