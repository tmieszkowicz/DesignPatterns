namespace Creational.Builder.StepBuilder;

public class s6_StepBuilder
{
    public void Run()
    {
        // 1. Identify the distinct steps
        // 2. Define each step as an interface
        // 3. Add a method (one or more) that moves you to the next step
        // 4. Have the last step build the final product
        // 5. Implement the interfaces
        // 6. Add an entry point in the builder, that returns the first step
        Pizza pizza = Pizza.Builder.Start()
            //.AddTopping("ham") // This line would cause an error
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
    public class Builder : IDoughStep, ISauceStep, ICheeseStep, IToppingStep
    {
        private Dough _dough = default!;
        private string _sauce = string.Empty;
        private string _cheese = string.Empty;
        private List<string> _topping = [];

        private Builder() { }

        public static IDoughStep Start() => new Builder();

        public ISauceStep SetDough(Action<Dough.Builder> buildDoughAction)
        {
            var doughBuilder = new Dough.Builder();
            buildDoughAction(doughBuilder);
            _dough = doughBuilder.Build();

            return this;
        }
        public ICheeseStep SetSauce(string sauce)
        {
            _sauce = sauce;
            return this;
        }
        public IToppingStep SetCheese(string cheese)
        {
            _cheese = cheese;
            return this;
        }
        public IToppingStep AddTopping(string topping)
        {
            _topping.Add(topping);
            return this;
        }
        public Pizza Build()
        {
            return new Pizza(_dough, _sauce, _cheese, _topping);
        }
    }
    public interface IDoughStep
    {
        ISauceStep SetDough(Action<Dough.Builder> buildDoughAction);
    }
    public interface ISauceStep
    {
        ICheeseStep SetSauce(string sauce);
    }
    public interface ICheeseStep
    {
        IToppingStep SetCheese(string cheese);
    }
    public interface IToppingStep
    {
        IToppingStep AddTopping(string topping);
        Pizza Build();
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