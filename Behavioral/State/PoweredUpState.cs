namespace DesignPatterns.Behavioral.State;

public class PoweredUpState : ICharacterState
{
    private int _powerUpDuration = 10; //10 ticks

    public void HandleDamage(Character character, int amount)
    {
        character.ModifyHealth(-amount / 2);
    }

    public void HandlePowerUpCollected(Character character)
    {
        _powerUpDuration = 10; //reset duration
    }

    public void HandleUpdate(Character character)
    {
        _powerUpDuration--;

        if (_powerUpDuration <= 0)
        {
            character.SetPowerUp(false);
            character.SetState(new NormalState());
        }
    }
}
