using System.Text.Json;

namespace DesignPatterns.Behavioral.TemplateMethod;

public class JsonParser : FileParser
{
    protected override Dictionary<string, string> ParseContent(string content)
    {
        return JsonSerializer.Deserialize<Dictionary<string, string>>(content)!;
    }
}
