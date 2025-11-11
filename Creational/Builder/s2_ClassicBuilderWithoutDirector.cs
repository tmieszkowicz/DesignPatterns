
namespace Creational.Builder.ClassicBuilder;

public class s1_ClassicBuilderWithoutDirector
{
    public void Run()
    {
        IBuilder builder = new SimpleProductBuilder();
        // IBuilder builder2 = new ComplexProductBuilder();

        builder.BuildName();
        builder.BuildDescription();

        Product product = builder.Build();
    }
}
