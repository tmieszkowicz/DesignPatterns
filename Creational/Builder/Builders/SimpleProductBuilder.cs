namespace Creational.Builder;

public class SimpleProductBuilder : IBuilder
{
    private string _name = string.Empty;
    private string _description = string.Empty;

    public Product Build() => new Product(Name: _name, Description: _description);
    public void BuildDescription()
    {
        _description = "Simple Product Description";
    }

    public void BuildName()
    {
        _name = "Simple Product";
    }
}
