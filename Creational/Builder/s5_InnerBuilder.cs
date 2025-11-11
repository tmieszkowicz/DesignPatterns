namespace Creational.Builder.InnerBuilder;

public class s5_InnerBuilder
{
    public void Run()
    {
        Pizza pizza = new Pizza.Builder()
            .SetDough(dough => dough
                .SetThickness(2)
                .SetFlourType("whole wheat"))
            .SetSauce("mild")
            .SetCheese("mozzarella")
            .AddTopping("ham")
            .AddTopping("mushrooms")
            .Build();
    }
}

public record Pizza(Dough Dough, string Sauce, string Cheese, List<string> Topping)
{
    public class Builder
    {
        private Dough _dough = default!;
        private string _sauce = string.Empty;
        private string _cheese = string.Empty;
        private List<string> _topping = [];

        public Builder SetDough(Action<Dough.Builder> buildDoughAction)
        {
            var doughBuilder = new Dough.Builder();
            buildDoughAction(doughBuilder);
            _dough = doughBuilder.Build();

            return this;
        }
        public Builder SetSauce(string sauce)
        {
            _sauce = sauce;
            return this;
        }
        public Builder SetCheese(string cheese)
        {
            _cheese = cheese;
            return this;
        }
        public Builder AddTopping(string topping)
        {
            _topping.Add(topping);
            return this;
        }
        public Pizza Build()
        {
            return new Pizza(_dough, _sauce, _cheese, _topping);
        }
    }
}

public record Dough(int Thickness, string FlourType)
{
    public class Builder
    {
        private int _thickness;
        private string _flourType = string.Empty;

        public Builder SetThickness(int thickness)
        {
            _thickness = thickness;
            return this;
        }
        public Builder SetFlourType(string flourType)
        {
            _flourType = flourType;
            return this;
        }
        public Dough Build()
        {
            return new Dough(_thickness, _flourType);
        }
    }
}