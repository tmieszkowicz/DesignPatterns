namespace Structural.Flyweight.DocumentEditor;

public class Glyph : IGlyph
{
    private readonly char _character;
    private readonly string _fontFamily;

    public Glyph(char character, string fontFamily)
    {
        _character = character;
        _fontFamily = fontFamily;

        Console.WriteLine($"Creating Glyph for character '{character}' with font '{fontFamily}'");
    }

    public void Render(int x, int y, int size, string color)
    {
        //uses both intrinsic (character, fontFamily) and extrinsic (x, y, size, color) state
        Console.WriteLine($"Rendering '{_character}' in font '{_fontFamily}' at ({x},{y}) with size {size} and color {color}");

        //in real application there would be rendering logic here
        //using extrinsic and intrinsic state
    }
}