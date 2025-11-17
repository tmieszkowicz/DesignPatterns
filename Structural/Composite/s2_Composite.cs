namespace DesignPatterns.Structural.Composite;

public class s2_Composite()
{
    public void Run()
    {
        LearningResource root = new Bundle(name: "Zero to Hero");

        LearningResource leafA = new Course(
            name: "Course 1",
            duration: TimeSpan.FromHours(3),
            price: 100);

        LearningResource leafB = new Course(
            name: "Course 2",
            duration: TimeSpan.FromHours(4),
            price: 40);

        root.Add(leafA);
        root.Add(leafB);

        Console.WriteLine(root.GetPrice());
    }
}