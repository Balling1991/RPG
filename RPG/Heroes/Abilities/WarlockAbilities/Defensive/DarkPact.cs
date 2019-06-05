namespace RPG.Heroes.Abilities.WarlockAbilities.Defensive
{
    public class DarkPact : IDefensiveSpellAbility
    {
        private const string AbilityName = "Dark Pact";
        private const int AvailabilityLevel = 6;
        private const int ManaCost = 28;
        private const int BaseArmor = 5;
        private const int BaseSpellResistance = 6;
        private const AbilityType Type = AbilityType.DefensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public DarkPact()
        {
        }

        public int CalculateArmor(int intellect)
        {
            return BaseArmor + (intellect / 5);
        }

        public int CalculateResistance(int intellect)
        {
            return BaseSpellResistance + (intellect / 3);
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
