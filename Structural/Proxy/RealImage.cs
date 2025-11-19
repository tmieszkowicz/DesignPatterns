namespace DesignPatterns.Structural.Proxy;

public class RealImage : IImage
{
    private readonly string _fileName;
    private string _asciiArt = string.Empty;

    private void LoadImageFromDisk()
    {
        Thread.Sleep(3000);
        _asciiArt =
            "  .-''''-.\n" +
            " /        \\\n" +
            "|          |\n" +
            "|          |\n" +
            " \\        /\n" +
            "  '-.__.-'";
    }

    public RealImage(string fileName)
    {
        Console.WriteLine("Instantiating RealImage");
        LoadImageFromDisk();
        _fileName = fileName;
    }

    public void Display()
    {
        Console.WriteLine("Displaying High Resolution Image");
        Console.WriteLine(_asciiArt);
    }
}
