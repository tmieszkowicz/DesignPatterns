namespace DesignPatterns.Behavioral.TemplateMethod;

public abstract class FileParser
{
    public Dictionary<string, string> ParseFile(string path)
    {
        LogOperation($"Validating {path}");
        ValidateFile(path);

        LogOperation("Loading the file");
        var content = File.ReadAllText(path);

        LogOperation("Parsing the file..");
        Dictionary<string, string> data = ParseContent(content);

        Console.WriteLine("Enriching the data");
        EnrichData(data);

        Console.WriteLine("Validating the data");
        ValidateData(data);

        return data;
    }

    protected virtual void ValidateData(Dictionary<string, string> data)
    {
    }

    protected virtual void EnrichData(Dictionary<string, string> data)
    {
        data["parsedAt"] = DateTime.UtcNow.ToString();
    }

    private void ValidateFile(string path)
    {
        if (!File.Exists(path))
        {
            throw new Exception("File does not exist.");
        }

        if (new FileInfo(path).Length == 0)
        {
            throw new Exception("File is empty.");
        }
    }

    protected abstract Dictionary<string, string> ParseContent(string content);

    public virtual void LogOperation(string message)
    {
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: {message}");
    }
}
