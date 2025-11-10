using DesignPatterns.Creational.AbstractFactory.Common;
namespace DesignPatterns.Creational.AbstractFactory.Common;

public interface ILevelElementFactory
{
    IMonster CreateMonster();

    IWeapon CreateWeapon();
    IPower CreatePower();
}