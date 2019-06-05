namespace RPG.Heroes.Abilities.PriestAbilities.Defensive
{
    public class LesserHeal : IDefensiveSpellAbility
    {
        private const string AbilityName = "Lesser Heal";
        private const int AvailabilityLevel = 4;
        private const int BaseHealing = 45;
        private const int ManaCost = 30;
        private const AbilityType Type = AbilityType.DefensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public LesserHeal()
        {
        }

        public int CalculateHealing(int intellect)
        {
            return BaseHealing + intellect;
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
