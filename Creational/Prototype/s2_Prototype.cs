namespace Creational.Prototype;

public class s2_Prototype
{
    public void Run()
    {
        var rectangle = new Rectangle(100, 100, Color.LightGray);
    }

    void CopyDrag(IShape shape)
    {
        var newShape = shape.Clone();

        // while (isMouseDown)
        // {
        //     //draw new shape to cursor position
        // }
    }
}