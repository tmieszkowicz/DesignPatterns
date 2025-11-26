namespace DesignPatterns.Behavioral.Iterator1;

public class s1_Iterator
{
    public void Run()
    {
        Aggregate<int> aggregate = new ConcreteAggregate<int>();
        aggregate.Add(1);
        aggregate.Add(2);
        aggregate.Add(3);

        Iterator<int> iterator = aggregate.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}

public interface Aggregate<T>
{
    Iterator<T> CreateIterator();
    void Add(T value);
}

public class ConcreteAggregate<T> : Aggregate<T>
{
    private readonly List<T> _items = [];

    public int Count => _items.Count;

    public T GetItemAt(int index)
    {
        return _items[index];
    }

    public void Add(T value)
    {
        _items.Add(value);
    }

    public Iterator<T> CreateIterator()
    {
        return new ConcreteIterator<T>(this);
    }
}

public interface Iterator<T>
{
    bool HasNext();
    T Next();
    void Reset();
}

public class ConcreteIterator<T>(ConcreteAggregate<T> aggregate) : Iterator<T>
{
    private readonly ConcreteAggregate<T> _aggregate = aggregate;
    private int _currentIndex = -1;

    public bool HasNext()
    {
        return _currentIndex < _aggregate.Count - 1;
    }

    public T Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException();
        }

        _currentIndex++;
        return _aggregate.GetItemAt(_currentIndex);
    }

    public void Reset()
    {
        _currentIndex = -1;
    }
}

