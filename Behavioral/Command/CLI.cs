namespace DesignPatterns.Behavioral.Command;

public class CLI
{
    private readonly Dictionary<string, ICommand> _commands = [];

    public void RegisterCommand(string commandName, ICommand command)
    {
        _commands[commandName] = command;
    }

    public void ExecuteCommand(string commandName, string[] args)
    {
        var concatenatedArgs = string.Join(" ", args);

        Console.WriteLine($"> {commandName} {concatenatedArgs}");
        if (!_commands.TryGetValue(commandName, out var command))
        {
            Console.WriteLine($"Unknown command: {commandName}");
            return;
        }

        command.Execute(args);
    }
}
