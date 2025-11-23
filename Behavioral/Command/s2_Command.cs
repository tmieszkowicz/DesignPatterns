namespace DesignPatterns.Behavioral.Command;

public class s2_Command
{
    public void Run()
    {
        CLI cli = new();
        FileSystemReceiver fileSystemReceiver = new();

        cli.RegisterCommand("ls", new ListCommand(fileSystemReceiver));
        cli.RegisterCommand("cd", new ChangeDirectoryCommand(fileSystemReceiver));
        cli.RegisterCommand("mkdir", new MakeDirectoryCommand(fileSystemReceiver));

        cli.ExecuteCommand(commandName: "ls", args: []);
        cli.ExecuteCommand(commandName: "mkdir", args: ["foo"]);
        cli.ExecuteCommand(commandName: "ls", args: []);
        cli.ExecuteCommand(commandName: "cd", args: ["foo"]);
        cli.ExecuteCommand(commandName: "mkdir", args: ["foo2"]);
        cli.ExecuteCommand(commandName: "ls", args: []);
        cli.ExecuteCommand(commandName: "cd", args: [".."]);
        cli.ExecuteCommand(commandName: "ls", args: ["foo"]);
        cli.ExecuteCommand(commandName: "123", args: ["foo"]);
    }
}
