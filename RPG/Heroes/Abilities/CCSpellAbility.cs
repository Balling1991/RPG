namespace RPG.Heroes.Abilities
{
    public abstract class CCSpellAbility : IAbility
    {
        public abstract string GetAbilityName();
        public abstract int GetAvailabilityLevel();
    }
}
