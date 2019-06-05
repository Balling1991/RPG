namespace RPG.Heroes.Abilities.HunterAbilities.Offensive
{
    public class InstantArrow : IOffensiveMeleeEnergyAbility
    {
        private const string AbilityName = "Instant Arrow";
        private const AbilityType Type = AbilityType.OffensiveMelee;
        private const int AvailabilityLevel = 3;
        private const int BaseDamage = 12;
        private const int EnergyCost = 45;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public InstantArrow()
        {
        }

        public int CalculateDamage(int agility)
        {
            return BaseDamage + agility;
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

        public int GetEnergyCost()
        {
            return EnergyCost;
        }

        public int GetEnergyGain()
        {
            throw new System.NotImplementedException();
        }

        public AbilityResourceKind GetResourceKind()
        {
            return ResourceKind;
        }
    }
}
