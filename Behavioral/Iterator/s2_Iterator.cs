namespace DesignPatterns.Behavioral.Iterator;

public class s2_Iterator
{
    public void Run()
    {
        IPrimeCollection primes = new PrimeCollection(count: 5);

        IPrimeIterator iterator = primes.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}
