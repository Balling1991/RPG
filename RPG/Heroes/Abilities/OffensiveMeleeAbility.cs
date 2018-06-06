namespace RPG.Heroes.Abilities
{
    public abstract class OffensiveMeleeAbility : IAbility
    {
        protected int BaseDamage { get; set; }
        protected int EnergyCost { get; set; }

        public abstract int GetAvailabilityLevel();
    }
}
