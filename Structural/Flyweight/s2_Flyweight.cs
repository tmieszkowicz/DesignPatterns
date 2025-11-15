namespace Structural.Flyweight.DocumentEditor;

public class s2_Flyweight
{
    public void Run()
    {
        DocumentEditor documentEditor = new(new GlyphFactory());

        string text = "Hello Flyweight!";
        int x = 10;
        int y = 10;

        foreach (char c in text)
        {
            documentEditor.InsertCharacter(c, "Ariel", x, y, 12, "Black");
            x += 10;
        }

        string upperCaseText = text.ToUpper();

        foreach (char c in upperCaseText)
        {
            documentEditor.InsertCharacter(c, "Times New Roman", x, y, 18, "Red");
            x += 20;
        }

        documentEditor.Render();
    }
}