namespace RPG.Heroes.Abilities.NecromancerAbilities.Defensive
{
    public class BoneShield : IDefensiveSpellAbility
    {
        private const string AbilityName = "Bone Shield";
        private const int AvailabilityLevel = 10;
        private const int BaseArmor = 5;
        private const int BaseSpellResistance = 15;
        private const int ManaCost = 18;
        private const AbilityType Type = AbilityType.DefensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public BoneShield()
        {
        }

        public int CalculateArmor(int intellect)
        {
            return BaseArmor + (intellect / 2);
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
