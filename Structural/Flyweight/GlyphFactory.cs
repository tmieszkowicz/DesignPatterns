namespace Structural.Flyweight.DocumentEditor;

public class GlyphFactory
{
    private readonly Dictionary<(char character, string fontFamily), IGlyph> _glyphs = [];
    public IGlyph GetGlyph(char character, string fontFamily)
    {
        if (!_glyphs.ContainsKey((character, fontFamily)))
        {
            _glyphs[(character, fontFamily)] = new Glyph(character, fontFamily);
        }

        return _glyphs[(character, fontFamily)];
    }
}