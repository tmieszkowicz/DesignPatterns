namespace DesignPatterns.Memento;

public class s2_Memento
{
    public void Run()
    {
        TextBox textBox = new();
        TextHistory textHistory = new();

        textBox.SetText("Hello");
        textHistory.BackUp(textBox.Save());

        textBox.SetText("Hello World!");
        textHistory.BackUp(textBox.Save());

        Console.WriteLine($"Current text: {textBox.GetText()}");

        textHistory.Undo(textBox);
        Console.WriteLine($"After undo: {textBox.GetText()}");

        textHistory.Undo(textBox);
        Console.WriteLine($"After second undo: {textBox.GetText()}");

        textHistory.Redo(textBox);
        Console.WriteLine($"After redo: {textBox.GetText()}");
    }
}
