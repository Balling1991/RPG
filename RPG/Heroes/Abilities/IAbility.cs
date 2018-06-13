namespace RPG.Heroes.Abilities
{
    public interface IAbility
    {
        string GetAbilityName();

        AbilityType GetAbilityType();

        int GetAvailabilityLevel();
    }
}