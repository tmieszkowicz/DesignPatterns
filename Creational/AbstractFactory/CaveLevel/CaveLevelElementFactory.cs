using DesignPatterns.Creational.AbstractFactory.Common;

public class CaveLevelElementFactory : ILevelElementFactory
{
    public IMonster CreateMonster()
    {
        return new Troll();
    }

    public IPower CreatePower()
    {
        return new Crystal();
    }

    public IWeapon CreateWeapon()
    {
        return new Axe();
    }
}
