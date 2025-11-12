namespace Structural.Adapter;

public class LegacyRectangle(int left, int top, int right, int bottom)
{
    public int CalculateArea()
    {
        return (right - left) * (bottom - top);
    }

    public int CalculatePerimeter()
    {
        return 2 * ((right - left) + (bottom - top));
    }

    public void Shift(int horizontal, int vertical)
    {
        left += horizontal;
        right += horizontal;
        top += vertical;
        bottom += vertical;
    }
}