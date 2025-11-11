namespace Creational.Builder;

public class ProductDirector(IBuilder builder)
{
    public void ConstructProduct()
    {
        builder.BuildName();
        builder.BuildDescription();
    }
}