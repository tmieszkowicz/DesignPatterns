using DesignPatterns.Creational.AbstractFactory.Common;

public class HauntedHouseLevelElementFactory : ILevelElementFactory
{
    public IMonster CreateMonster()
    {
        return new Ghoul();
    }

    public IPower CreatePower()
    {
        return new Orb();
    }

    public IWeapon CreateWeapon()
    {
        return new Staff();
    }
}
