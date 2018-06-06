namespace RPG.Heroes.Abilities.WarlockAbilities.Defensive
{
    public class DarkPact : DefensiveSpellAbility
    {
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

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
