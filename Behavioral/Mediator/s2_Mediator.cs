namespace DesignPatterns.Behavioral.Mediator;

public class s2_Mediator()
{
    public void Run()
    {
        ChatRoom chatRoom = new();

        RegularUser alice = new("Alice");
        RegularUser bob = new("Bob");
        AdminUser charlie = new("Charlie");

        chatRoom.AddUser(alice);
        chatRoom.AddUser(bob);
        chatRoom.AddUser(charlie);

        charlie.Send("Welcome, everybody!");

        alice.Send("Hello everyone!");
        bob.Send("Hey Alice, how are you?");
        alice.Send("I'm good, thanks");

        charlie.BroadcastAlert("Keep it friendly guys!");
    }
}
