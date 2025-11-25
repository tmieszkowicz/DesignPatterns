namespace DesignPatterns.Behavioral.Interpreter1;

public class s1_Interpreter
{
    public void Run()
    {
        //1 + 2 * 3
        Expression expression = new AddExpression(
            left: new NumberExpression(1),
            right: new MultiplyExpression(
                left: new NumberExpression(2),
                right: new NumberExpression(3)
            )
        );

        expression.Interpret(); // 7
    }
}

public abstract class Expression
{
    public abstract int Interpret();
}

public class NumberExpression(int number) : Expression
{
    private readonly int _number = number;

    public override int Interpret()
    {
        return _number;
    }
}

public class AddExpression(Expression left, Expression right) : Expression
{
    private readonly Expression _left = left;
    private readonly Expression _right = right;

    public override int Interpret()
    {
        return _left.Interpret() + _right.Interpret();
    }
}

public class MultiplyExpression(Expression left, Expression right) : Expression
{
    private readonly Expression _left = left;
    private readonly Expression _right = right;

    public override int Interpret()
    {
        return _left.Interpret() * _right.Interpret();
    }
}
