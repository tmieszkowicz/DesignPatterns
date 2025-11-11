namespace Creational.Prototype;

public class s1_PrototypeCopies
{
    public void Run()
    {
        var person = new Person("Alice", new List<string> { "Reading", "Hiking" });
        var shallowCopy = person.ShallowCopy();
        var deepCopy = person.DeepCopy();

        shallowCopy.Hobbies.Add("Cooking");
        deepCopy.Hobbies.Add("Swimming");
    }
}


public record Person(string Name, List<string> Hobbies)
{
    public Person ShallowCopy()
    {
        return this with { };
    }
    public Person DeepCopy()
    {
        return new(Name, [.. Hobbies]);
    }
}