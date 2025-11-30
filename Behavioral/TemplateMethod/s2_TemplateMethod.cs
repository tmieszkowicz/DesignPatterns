namespace DesignPatterns.Behavioral.TemplateMethod;

public class s2_TemplateMethod
{
    public void Run()
    {
        FileParser csvParser = new CsvParser();
        FileParser jsonParser = new JsonParser();

        var csvData = csvParser.ParseFile("config.csv");
        var jsonData = jsonParser.ParseFile("config.json");

        Console.WriteLine("Printing CSV data");
        foreach (var pair in csvData)
        {
            Console.WriteLine($"{pair.Key} = {pair.Value}");
        }

        Console.WriteLine("Printing json data");
        foreach (var pair in jsonData)
        {
            Console.WriteLine($"{pair.Key} = {pair.Value}");
        }
    }
}
