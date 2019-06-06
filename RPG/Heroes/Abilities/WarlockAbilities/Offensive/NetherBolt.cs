namespace RPG.Heroes.Abilities.WarlockAbilities.Offensive
{
    public class NetherBolt : IOffensiveSpellAbility
    {
        private const string AbilityName = "Netherbolt";
        private const int AvailabilityLevel = 1;
        private const int BaseDamage = 13;
        private const int ManaCost = 40;
        private const AbilityType Type = AbilityType.OffensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public NetherBolt()
        {
        }

        public int CalculateDamage(int intellect)
        {
            return BaseDamage + intellect;
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
