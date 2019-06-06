namespace RPG.Heroes.Abilities.WarriorAbilities.Offensive
{
    public class BleedDOT : IOffensiveMeleeRageAbility
    {
        private const string AbilityName = "Bleed";
        private const int AvailabilityLevel = 4;
        private const int BaseDamage = 2;
        private const int RageCost = 20;
        private const AbilityType Type = AbilityType.OffensiveRageMelee;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public BleedDOT()
        {
        }

        public int CalculateDamage(int strength)
        {
            return BaseDamage + (strength / 3);
        }

        public string GetAbilityName()
        {
            return AbilityName;
        }

        public AbilityType GetAbilityType()
        {
            return Type;
        }

        public int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }

        public int GetDamage()
        {
            return BaseDamage;
        }

        public int GetRageCost()
        {
            return RageCost;
        }

        public int GetRageGain(bool isCrit)
        {
            return 0;
        }

        public AbilityResourceKind GetResourceKind()
        {
            return ResourceKind;
        }
    }
}
