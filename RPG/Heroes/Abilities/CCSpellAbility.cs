namespace RPG.Heroes.Abilities
{
    public abstract class CCSpellAbility : IAbility
    {
        public abstract string GetAbilityName();

        public abstract AbilityType GetAbilityType();

        public abstract int GetAvailabilityLevel();
    }
}
