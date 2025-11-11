namespace Creational.Prototype;

public class Color(ushort red, ushort green, ushort blue) : IPrototype<Color>
{
    public static Color LightGray => new Color(211, 211, 211);

    public Color Clone()
    {
        return new Color(red, green, blue);
    }
}