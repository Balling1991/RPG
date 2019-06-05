namespace RPG.Heroes.Abilities.AssassinAbilities.Offensive
{
    public class Stab : IOffensiveMeleeEnergyAbility
    {
        private const string AbilityName = "Stab";
        private const int AvailabilityLevel = 1;
        private const int BaseDamage = 5;
        private const int EnergyCost = 35;
        private const AbilityType Type = AbilityType.OffensiveMelee;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public Stab()
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
