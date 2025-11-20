namespace DesignPatterns.Structural.Decorator;

class BasicTeslaModel3 : ITeslaModel3
{
    public string GetDescription()
    {
        return "Tesla Model 3 Rear-Wheel Drive";
    }

    public decimal GetPrice()
    {
        return 38990m;
    }

    public int GetRange()
    {
        return 272;
    }
}
