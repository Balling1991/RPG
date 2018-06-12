namespace RPG.Heroes.Abilities
{
    public abstract class OffensiveSpellAbility : IAbility
    {
        protected int BaseDamage { get; set; }
        protected int ManaCost { get; set; }

        public abstract string GetAbilityName();
        public abstract int GetAvailabilityLevel();
    }
}