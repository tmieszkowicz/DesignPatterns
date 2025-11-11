namespace Creational.Builder.FluentBuilder;

public class s4_FluentBuilder
{
    public void Run()
    {
        FluentProduct product = new FluentProduct.FluentBuilder()
            .SetName("Fluent Product")
            .SetDescription("Fluent Product Description")
            .Build();
    }
}

public record FluentProduct(string Name, string Description)
{
    public class FluentBuilder
    {
        private string _name = string.Empty;
        private string _description = string.Empty;

        public FluentBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public FluentBuilder SetDescription(string description)
        {
            _description = description;
            return this;
        }

        public FluentProduct Build()
        {
            return new FluentProduct(_name, _description);
        }
    }
}