using DesignPatterns.Structural.Bridge.ClothingFormatters;

namespace DesignPatterns.Structural.Bridge.ClothingViews;

public abstract class ClothingView(IClothingFormatter clothingFormatter)
{
    public IClothingFormatter ClothingFormatter { get; init; } = clothingFormatter;
    public abstract void Display();
}
