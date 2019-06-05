namespace RPG.Heroes.Abilities.AssassinAbilities.Offensive
{
    public class VenomStrike : IOffensiveMeleeEnergyAbility
    {
        private const string AbilityName = "Venom Strike";
        private const int AvailabilityLevel = 4;
        private const int BaseDamage = 9;
        private const int EnergyCost = 25;
        private const AbilityType Type = AbilityType.OffensiveMelee;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public VenomStrike()
        {
        }

        public int CalculateDamage(int agility, int strength)
        {
            return BaseDamage + agility + (strength / 5);
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
