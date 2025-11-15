namespace Structural.Flyweight.DocumentEditor;

public class DocumentEditor(GlyphFactory factory)
{
    private readonly GlyphFactory _factory = factory;
    private readonly List<(IGlyph glyph, int x, int y, int size, string color)> _characters = [];

    public void InsertCharacter(char character, string fontFamily, int x, int y, int size, string color)
    {
        Console.WriteLine($"Inserting '{character} at ({x}, {y})");

        var glyph = _factory.GetGlyph(character, fontFamily);
        _characters.Add((glyph, x, y, size, color));
    }

    public void Render()
    {
        Console.WriteLine("Rendering document:");

        foreach (var glyphChar in _characters)
        {
            glyphChar.glyph.Render(glyphChar.x, glyphChar.y, glyphChar.size, glyphChar.color);
        }
    }
}