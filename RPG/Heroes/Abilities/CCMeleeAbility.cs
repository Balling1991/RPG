namespace RPG.Heroes.Abilities
{
    public abstract class CCMeleeAbility : IAbility
    {
        public abstract string GetAbilityName();
        public abstract int GetAvailabilityLevel();
    }
}
