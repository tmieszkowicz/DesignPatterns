namespace DesignPatterns.Behavioral.TemplateMethod;

public class CsvParser : FileParser
{
    protected override Dictionary<string, string> ParseContent(string content)
    {
        Dictionary<string, string> result = [];

        foreach (var row in content.Split('\n'))
        {
            var parts = row.Split(',');
            result[parts[0]] = parts[1];
        }

        return result;
    }

    protected override void EnrichData(Dictionary<string, string> data)
    {
        base.EnrichData(data);
        data["dataType"] = "CSV";
    }
}
