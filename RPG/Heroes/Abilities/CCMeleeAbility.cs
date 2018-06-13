namespace RPG.Heroes.Abilities
{
    public abstract class CCMeleeAbility : IAbility
    {
        public abstract string GetAbilityName();

        public abstract AbilityType GetAbilityType();

        public abstract int GetAvailabilityLevel();
    }
}
