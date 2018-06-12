namespace RPG.Heroes.Abilities
{
    public abstract class DefensiveMeleeAbility : IAbility
    {
        protected int BaseArmor { get; set; }
        protected int BaseResistance { get; set; }
        protected int EnergyCost { get; set; }

        public abstract string GetAbilityName();
        public abstract int GetAvailabilityLevel();
    }
}
