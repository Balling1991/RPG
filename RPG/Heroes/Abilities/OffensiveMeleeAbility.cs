using RPG.NPC.HostileCreatures;

namespace RPG.Heroes.Abilities
{
    public abstract class OffensiveMeleeAbility : IAbility
    {
        protected int BaseDamage { get; set; }
        protected int EnergyCost { get; set; }

        protected int RageCost { get; set; }

        public abstract string GetAbilityName();

        public abstract AbilityType GetAbilityType();

        public abstract int GetAvailabilityLevel();

        public abstract int GetDamage();
    }
}
