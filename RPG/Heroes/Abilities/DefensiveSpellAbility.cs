namespace RPG.Heroes.Abilities
{
    public abstract class DefensiveSpellAbility : IAbility
    {
        protected int BaseArmor { get; set; }
        protected int BaseResistance { get; set; }
        protected int BaseHealing { get; set; }
        protected int ManaCost { get; set; }

        public abstract string GetAbilityName();
        public abstract int GetAvailabilityLevel();
    }
}
