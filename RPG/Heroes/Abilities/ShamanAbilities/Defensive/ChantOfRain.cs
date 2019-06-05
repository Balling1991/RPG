namespace RPG.Heroes.Abilities.ShamanAbilities.Defensive
{
    public class ChantOfRain : IDefensiveSpellAbility
    {
        private const string AbilityName = "Chant Of Rain";
        private const int AvailabilityLevel = 6;
        private const int BaseArmor = 8;
        private const int BaseSpellResistance = 6;
        private const int BaseHealing = 22;
        private const int ManaCost = 40;
        private const AbilityType Type = AbilityType.DefensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public ChantOfRain()
        {
        }

        public int CalculateArmor(int intellect, int agility)
        {
            return BaseArmor + (intellect / 4) + (agility / 2);
        }

        public int CalculateResistance(int intellect)
        {
            return BaseSpellResistance + intellect;
        }

        public int CalculateHealing(int intellect)
        {
            return BaseHealing + intellect;
        }

        public int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }

        public string GetAbilityName()
        {
            return AbilityName;
        }

        public AbilityType GetAbilityType()
        {
            return Type;
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
