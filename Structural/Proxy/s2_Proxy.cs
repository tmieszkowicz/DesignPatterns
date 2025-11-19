namespace DesignPatterns.Structural.Proxy;

public class s2_Proxy()
{
    public void Run()
    {
        IImage image1 = new ProxyImage(fileName: "test_image1.jpg");
        IImage image2 = new ProxyImage(fileName: "test_image2.jpg");

        Console.WriteLine("Displaying image1");
        image1.Display();
        Console.WriteLine("Displaying image2");
        image2.Display();

        Console.WriteLine("Displaying image1 again");
        image1.Display();
        Console.WriteLine("Displaying image1 again");
        image1.Display();
    }
}