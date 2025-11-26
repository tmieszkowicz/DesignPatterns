using System.Collections;

namespace DesignPatterns.Behavioral.Iterator3;

public class s3_IteratorVsEnumerable
{
    public void Run()
    {
        var primes = new PrimeCollection(count: 5);

        foreach (var prime in primes)
        {
            Console.WriteLine(prime);
        }
    }
}

public class PrimeCollection(int count) : IEnumerable<int>
{
    public int Count { get; } = count;
    public IEnumerator<int> GetEnumerator()
    {
        return new PrimeIterator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public interface IPrimeIterator
{
    bool HasNext();
    int Next();
    void Reset();
}

public class PrimeIterator(PrimeCollection primes) : IEnumerator<int>
{
    private readonly PrimeCollection _primes = primes;
    private int _itemsReturned = 0;
    private int _current = 1;

    public int Current => _current;

    object IEnumerator.Current => Current;

    public bool HasNext()
    {
        return _itemsReturned < _primes.Count;
    }

    public bool MoveNext()
    {
        if (!HasNext())
        {
            return false;
        }

        while (!IsPrime(++_current)) ;

        _itemsReturned++;
        return true;
    }

    private bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

    public void Reset()
    {
        _itemsReturned = 0;
        _current = 1;
    }

    public void Dispose()
    {
    }
}
