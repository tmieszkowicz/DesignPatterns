namespace DesignPatterns.Behavioral.Command;

public class ListCommand(FileSystemReceiver receiver) : ICommand
{
    private readonly FileSystemReceiver _receiver = receiver;

    //ls
    //ls path
    public void Execute(string[] args)
    {
        var path = args.Length == 0 ? "." : args[0];

        _receiver.ListDirectory(path);
    }
}
