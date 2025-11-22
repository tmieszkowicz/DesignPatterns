namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public abstract class SpamHandler
{
    protected SpamHandler? _successor;

    public void SetSuccessor(SpamHandler successor)
    {
        _successor = successor;
    }

    public abstract bool HandleSpamCheck(Email email);
}
