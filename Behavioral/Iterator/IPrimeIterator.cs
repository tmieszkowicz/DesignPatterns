namespace DesignPatterns.Behavioral.Iterator;

public interface IPrimeIterator
{
    bool HasNext();
    int Next();
    void Reset();
}
