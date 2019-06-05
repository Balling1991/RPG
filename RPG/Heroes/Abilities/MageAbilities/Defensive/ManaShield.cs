namespace RPG.Heroes.Abilities.MageAbilities.Defensive
{
    public class ManaShield : IDefensiveSpellAbility
    {
        private const string AbilityName = "Mana Shield";
        private const int AvailabilityLevel = 6;
        private const int BaseArmor = 5;
        private const int BaseSpellResistance = 15;
        private const int ManaCost = 30;
        private const AbilityType Type = AbilityType.DefensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public ManaShield()
        {
        }

        public int CalculateResistance(int intellect)
        {
            return BaseSpellResistance + intellect;
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
