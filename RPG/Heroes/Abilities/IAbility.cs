namespace RPG.Heroes.Abilities
{
    public interface IAbility
    {
        string GetAbilityName();
        int GetAvailabilityLevel();
        AbilityType GetAbilityType();
        AbilityResourceKind GetResourceKind();
    }
}