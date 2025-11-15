namespace Structural.Flyweight;

using Key = String;

public class s1_Flyweight
{
    public void Run()
    {
        FlyweightFactory factory = new();
        Client client = new(factory);

        client.Operation("HI");
        client.Operation("HELLO");
    }
}

public class Client(FlyweightFactory factory)
{
    private readonly FlyweightFactory _factory = factory;
    public void Operation(string extrinsicState)
    {
        Key key1 = extrinsicState[0].ToString();
        Key key2 = extrinsicState[0].ToString();

        IFlyweight flyweight1 = _factory.GetFlyweight(key1);
        IFlyweight flyweight2 = _factory.GetFlyweight(key2);

        flyweight1.Operation(extrinsicState);
        flyweight2.Operation(extrinsicState);
    }
}

public class FlyweightFactory
{
    private readonly Dictionary<Key, IFlyweight> _flyweights = [];
    public IFlyweight GetFlyweight(Key key)
    {
        if (!_flyweights.ContainsKey(key))
        {
            _flyweights[key] = new Glyph(intrinsicState: key);
        }

        return _flyweights[key];
    }
}

public interface IFlyweight
{
    public void Operation(string extrinsicState);
}

public class Glyph(string intrinsicState) : IFlyweight
{
    private readonly string _intrinsicState = intrinsicState;
    public void Operation(string extrinsicState)
    {
        Console.WriteLine($"Intrinsic State: {_intrinsicState}, Extrinsic State: {extrinsicState}");
    }
}