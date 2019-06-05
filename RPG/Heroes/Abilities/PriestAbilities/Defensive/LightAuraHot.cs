namespace RPG.Heroes.Abilities.PriestAbilities.Defensive
{
    public class LightAuraHOT : IDefensiveSpellAbility
    {
        private const string AbilityName = "Light Aura";
        private const int AvailabilityLevel = 10;
        private const int BaseArmor = 2;
        private const int BaseHealing = 8;
        private const int ManaCost = 45;
        private const AbilityType Type = AbilityType.DefensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public LightAuraHOT()
        {
        }

        public int CalculateArmor(int intellect)
        {
            return BaseArmor + (intellect / 5);
        }

        public int CalculateHealing(int intellect)
        {
            return BaseHealing + (intellect / 2);
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
