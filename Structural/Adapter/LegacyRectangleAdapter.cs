namespace Structural.Adapter;

public class LegacyRectangleAdapter(LegacyRectangle legacyRectangle) : IRectangle
{
    public int GetArea()
    {
        return legacyRectangle.CalculateArea();
    }

    public int GetPerimeter()
    {
        return legacyRectangle.CalculatePerimeter();
    }

    public void Move(long deltaX, long deltaY)
    {
        legacyRectangle.Shift(
            horizontal: Convert.ToInt32(deltaX),
            vertical: Convert.ToInt32(deltaY));
    }
}