namespace RPG.Heroes.Abilities.WarlockAbilities.Defensive
{
    public class DarkPact : DefensiveSpellAbility
    {
        private const string AbilityName = "Dark Pact";
        private const AbilityType Type = AbilityType.DefensiveSpell;
        private const int AvailabilityLevel = 6;

        public DarkPact()
        {
            BaseArmor = 5;
            BaseResistance = 6;
            BaseHealing = 0;
        }

        public int CalculateArmor(int intellect)
        {
            return BaseArmor + (intellect / 5);
        }

        public int CalculateResistance(int intellect)
        {
            return BaseResistance + (intellect / 3);
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
