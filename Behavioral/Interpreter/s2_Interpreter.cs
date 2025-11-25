namespace DesignPatterns.Behavioral.Interpreter;

public class s2_Interpreter
{
    public void Run()
    {
        List<string> context = new List<string>
        {
            "hello",
            "world",
            "elephant",
            "help"
        };

        Expression helloExpression = new WordExpression("hello");
        helloExpression.Interpret(context);
        Console.WriteLine(string.Join(", ", helloExpression.Interpret(context)));

        Expression notHelloExpression = new NotExpression("hello");
        notHelloExpression.Interpret(context);
        Console.WriteLine(string.Join(", ", notHelloExpression.Interpret(context)));

        Expression containsExpression = new ContainsExpression("el");
        containsExpression.Interpret(context);
        Console.WriteLine(string.Join(", ", containsExpression.Interpret(context)));

        Expression andExpression = new AndExpression(left: notHelloExpression, right: containsExpression);
        andExpression.Interpret(context);
        Console.WriteLine(string.Join(", ", andExpression.Interpret(context)));
    }
}
