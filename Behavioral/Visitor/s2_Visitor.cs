namespace DesignPatterns.Behavioral.Visitor;


public class s2_Visitor()
{
    public void Run()
    {
        List<IDocumentElement> elements = [
            new TitleElement("Title"),
            new SubtitleElement("Subtitle"),
            new ContentElement("Content"),
            new SubtitleElement("Subtitle 2"),
            new ContentElement("Content 2")
        ];

        Console.WriteLine("Text format:");
        TextDocumentVisitor textDocumentVisitor = new();

        foreach (var element in elements)
        {
            element.Accept(textDocumentVisitor);
        }

        Console.WriteLine("Markdown format:");
        MarkdownDocumentVisitor markdownDocumentVisitor = new();

        foreach (var element in elements)
        {
            element.Accept(markdownDocumentVisitor);
        }
    }
}
