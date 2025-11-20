namespace DesignPatterns.Structural.Decorator;

public class s2_Decorator()
{
    public void Run()
    {
        ITeslaModel3 car = new LongRangeTeslaDecorator(
            car: new RedPaintTeslaDecorator(
                car: new BasicTeslaModel3()));

        Console.WriteLine($"{car.GetDescription()} costs {car.GetPrice():C} and has a range of {car.GetRange()} miles.");
    }
}
