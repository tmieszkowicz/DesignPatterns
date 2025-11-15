namespace Structural.Flyweight.DocumentEditor;

public interface IGlyph
{
    public void Render(int x, int y, int size, string color);
}