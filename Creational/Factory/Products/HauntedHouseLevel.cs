public class HauntedHouseLevel : Level
{
    public override IEnemy EncounterEnemy()
    {
        return new Ghost();
    }
}