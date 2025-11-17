
namespace DesignPatterns.Structural.Composite;

public class Course(string name, TimeSpan duration, decimal price) : LearningResource
{
    public override TimeSpan GetDuration()
    {
        return duration;
    }

    public override string GetName()
    {
        return name;
    }

    public override decimal GetPrice()
    {
        return price;
    }
}