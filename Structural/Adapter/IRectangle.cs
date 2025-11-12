namespace Structural.Adapter;

public interface IRectangle
{
    int GetArea();
    int GetPerimeter();
    void Move(long deltaX, long deltaY);
}