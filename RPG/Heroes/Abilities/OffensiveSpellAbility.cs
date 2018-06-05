namespace RPG.Heroes.Abilities.MageAbilities
{
    public abstract class OffensiveSpellAbility : IAbility
    {
        protected int BaseDamage { get; set; }
        protected int ManaCost { get; set; }

        public abstract int GetAvailabilityLevel();
    }
}