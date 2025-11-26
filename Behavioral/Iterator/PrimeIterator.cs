namespace DesignPatterns.Behavioral.Iterator;

public class PrimeIterator(PrimeCollection primes) : IPrimeIterator
{
    private readonly PrimeCollection _primes = primes;
    private int _itemsReturned = 0;
    private int _current = 1;

    public bool HasNext()
    {
        return _itemsReturned < _primes.Count;
    }

    public int Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException();
        }

        while (!IsPrime(++_current)) ;

        _itemsReturned++;
        return _current;
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
}
