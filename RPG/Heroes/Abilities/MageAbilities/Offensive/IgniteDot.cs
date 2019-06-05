namespace RPG.Heroes.Abilities.MageAbilities.Offensive
{
    public class IgniteDOT : IOffensiveSpellAbility
    {
        private const string AbilityName = "Ignite";
        private const int AvailabilityLevel = 4;
        private const int BaseDamage = 2;
        private const int ManaCost = 6;
        private const AbilityType Type = AbilityType.OffensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public IgniteDOT()
        {
        }

        public int CalculateDamage(int intellect)
        {
            return BaseDamage + (intellect / 5);
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
