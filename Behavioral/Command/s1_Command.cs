namespace DesignPatterns.Behavioral.Command1;

public class s1_commands
{
    public void Run()
    {
        Receiver receiver = new();
        Command command1 = new ConcreteCommand(receiver, message: "1");
        Command command2 = new ConcreteCommand(receiver, message: "2");
        Command command3 = new ConcreteCommand(receiver, message: "3");
        Invoker invoker = new();

        invoker.AddCommand(command1);
        invoker.AddCommand(command2);
        invoker.AddCommand(command3);

        invoker.ExecuteCommands();

        invoker.UndoLastCommand();
        invoker.UndoLastCommand();
    }
}

public interface Command
{
    void Execute();
    void Undo();
}

public class ConcreteCommand(Receiver receiver, string message) : Command
{
    private readonly Receiver _receiver = receiver;
    private readonly string _message = message;

    public void Execute()
    {
        _receiver.Action(_message);
    }

    public void Undo()
    {
        _receiver.UndoAction(_message);
    }
}

public class Receiver
{
    public void Action(string message)
    {
        Console.WriteLine($"Receiver invoked: {message}.");
    }

    public void UndoAction(string message)
    {
        Console.WriteLine($"Receiver undoing: {message}.");
    }
}

public class Invoker
{
    private readonly List<Command> _commands = [];
    private readonly Stack<Command> _undoStack = [];

    public void AddCommand(Command command)
    {
        _commands.Add(command);
    }

    public void UndoLastCommand()
    {
        var command = _undoStack.Pop();
        command.Undo(); ;
    }

    public void ExecuteCommands()
    {
        foreach (var command in _commands)
        {
            command.Execute();
            _undoStack.Push(command);
        }

        _commands.Clear();
    }
}