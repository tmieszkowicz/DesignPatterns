namespace Creational.Builder;

public class ComplexProductBuilder : IBuilder
{
    private string _name = string.Empty;
    private string _description = string.Empty;

    public Product Build() => new Product(Name: _name, Description: _description);
    public void BuildDescription()
    {
        _description = "Complex Product Description";
    }

    public void BuildName()
    {
        _name = "Complex Product";
    }
}
