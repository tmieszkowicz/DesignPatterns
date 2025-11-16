using DesignPatterns.Structural.Bridge.ClothingFormatters;

namespace DesignPatterns.Structural.Bridge.ClothingViews;

public class CompactClothingView(IClothingFormatter clothingFormatter) : ClothingView(clothingFormatter)
{
    public override void Display()
    {
        Console.WriteLine($"Compact View:");
        Console.WriteLine($"Image: {ClothingFormatter.FormatImageUrl()}");
        Console.WriteLine($"Title: {ClothingFormatter.FormatTitle()}");
    }
}
