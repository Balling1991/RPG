using RPG.Heroes.Abilities.MageAbilities;

namespace RPG.Heroes.Abilities
{
    public abstract class DefensiveSpellAbility : IAbility
    {
        protected int BaseResistance { get; set; }
        protected int ManaCost { get; set; }

        public abstract int GetAvailabilityLevel();
    }
}
