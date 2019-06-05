namespace RPG.Heroes.Abilities.NecromancerAbilities.Offensive
{
    public class SummonSkeletonDOT : IOffensiveSpellAbility
    {
        private const string AbilityName = "Summon Skeleton";
        private const int AvailabilityLevel = 1;
        private const int BaseDamage = 2;
        private const int ManaCost = 10;
        private const AbilityType Type = AbilityType.OffensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public SummonSkeletonDOT()
        {
        }

        public int CalculateDamage(int intellect, int strength)
        {
            return BaseDamage + (intellect / 2) + (strength / 2);
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

        public int GetManaCost()
        {
            return ManaCost;
        }

        public AbilityResourceKind GetResourceKind()
        {
            return ResourceKind;
        }
    }
}
