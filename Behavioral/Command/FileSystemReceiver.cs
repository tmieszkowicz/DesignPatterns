


namespace DesignPatterns.Behavioral.Command;

public class FileSystemReceiver
{
    internal void ChangeDirectory(string path)
    {
        Directory.SetCurrentDirectory(path);
    }

    internal void ListDirectory(string path)
    {
        ListFolders(path);
        ListFiles(path);
    }

    internal void ListFiles(string path)
    {
        foreach (var file in Directory.GetFiles(path))
            Console.WriteLine(file);
    }
    internal void ListFolders(string path)
    {
        foreach (var dir in Directory.GetDirectories(path))
            Console.WriteLine($"{dir}/");
    }

    internal void MakeDirectory(string path)
    {
        Directory.CreateDirectory(path);
    }
}
