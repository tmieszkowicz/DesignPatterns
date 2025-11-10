using DesignPatterns.Creational.AbstractFactory.Common;
class s1_AbstractFactory
{
    public s1_AbstractFactory()
    {
        void SetupEnvironment(ILevelElementFactory levelFactory)
        {
            var monster = levelFactory.CreateMonster;
            var weapon = levelFactory.CreateWeapon();
            var power = levelFactory.CreatePower();
        }


        SetupEnvironment(new CaveLevelElementFactory());
        SetupEnvironment(new HauntedHouseLevelElementFactory());
    }
}