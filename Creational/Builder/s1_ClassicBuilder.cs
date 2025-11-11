namespace Creational.Builder.ClassicBuilder;

public class s1_ClassicBuilder
{
    public void Run()
    {
        IBuilder builder = new SimpleProductBuilder();
        // IBuilder builder2 = new ComplexProductBuilder();

        ProductDirector director = new ProductDirector(builder);
        director.ConstructProduct();

        Product product = builder.Build();
    }
}
