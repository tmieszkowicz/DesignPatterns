namespace Creational.Builder.NestedBuilder;

public class s3_NestedBuilder
{
    public void Run()
    {
        NestedProduct.Builder builder = new();

        builder.BuildName("Simple Product");
        builder.BuildDescription("Simple Product Description");

        NestedProduct product = builder.Build();
    }
}


public record NestedProduct(string Name, string Description)
{
    public class Builder
    {
        private string _name = string.Empty;
        private string _description = string.Empty;

        public void BuildName(string name) { _name = name; }
        public void BuildDescription(string description) { _description = description; }
        public NestedProduct Build() => new NestedProduct(_name, _description);
    }
}