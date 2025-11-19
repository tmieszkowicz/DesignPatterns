namespace DesignPatterns.Structural.Proxy;

public class ProxyImage : IImage
{
    private RealImage? _realImage = null;
    private readonly string _fileName;

    public ProxyImage(string fileName)
    {
        Console.WriteLine("Instantiating Proxy");
        _fileName = fileName;
    }

    public void Display()
    {
        Console.WriteLine("Performing operation in proxy");

        if (_realImage is null)
        {
            Console.WriteLine("Showing low resolution placeholder");
            Console.WriteLine("o");

            _realImage = new RealImage(_fileName);

            return;
        }

        _realImage.Display();
    }
}
