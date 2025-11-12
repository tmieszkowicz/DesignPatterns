namespace Structural.Adapter;

public class s2_Adapter
{
    public void Run()
    {
        var legacyRectangle = new LegacyRectangle(left: 0, top: 0, right: 10, bottom: 5);

        IRectangle rectangle = new LegacyRectangleAdapter(legacyRectangle);

        CenterRectangle(rectangle);
    }

    public void CenterRectangle(IRectangle rectangle)
    {
        // Move the rectangle to the center of an area
    }
}