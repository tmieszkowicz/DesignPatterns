namespace DesignPatterns.Structural.Composite1;

public class s1_Composite()
{
    public void Run()
    {
        Component root = new Composite();
        Component leafA = new Leaf();

        root.Add(leafA);

        Component childComposite = new Composite();
        Component leafB = new Leaf();
        Component leafC = new Leaf();

        childComposite.Add(leafB);
        childComposite.Add(leafC);

        root.Add(childComposite);

        root.Operation();
    }
}

public abstract class Component()
{
    public abstract void Operation();
    public virtual void Add(Component component) { }
    public virtual void Remove(Component component) { }
    public virtual Component? GetChild(int index) { return null; }
}

public class Composite() : Component
{
    private readonly List<Component> _children = [];
    public override void Operation()
    {
        foreach (var child in _children)
        {
            child.Operation();
        }
    }

    public override void Add(Component component)
    {
        _children.Add(component);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override Component? GetChild(int index)
    {
        if (index < 0 || index > _children.Count - 1)
            return null;

        return _children[index];
    }
}

public class Leaf() : Component
{
    public override void Operation()
    {
        //leaf specific operation
    }
}