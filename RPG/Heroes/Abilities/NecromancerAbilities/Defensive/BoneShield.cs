namespace RPG.Heroes.Abilities.NecromancerAbilities.Defensive
{
    public class BoneShield : DefensiveSpellAbility
    {
        private const string AbilityName = "Bone Shield";
        private const AbilityType Type = AbilityType.DefensiveSpell;
        private const int AvailabilityLevel = 10;

        public BoneShield()
        {
            BaseArmor = 5;
            BaseResistance = 15;
            BaseHealing = 0;
            ManaCost = 18;
        }

        public int CalculateArmor(int intellect)
        {
            return BaseArmor + (intellect / 2);
        }

        public int CalculateResistance(int intellect)
        {
            return BaseResistance + intellect;
        }

        public override string GetAbilityName()
        {
            return AbilityName;
        }

        public override AbilityType GetAbilityType()
        {
            return Type;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
