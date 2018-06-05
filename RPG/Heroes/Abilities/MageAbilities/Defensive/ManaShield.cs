namespace RPG.Heroes.Abilities.MageAbilities.Defensive
{
    public class ManaShield : DefensiveSpellAbility
    {
        private const int AvailabilityLevel = 6;

        public ManaShield()
        {
            BaseResistance = 15;
            ManaCost = 10;
        }

        public int CalculateResistance(int intellect)
        {
            return BaseResistance + intellect;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
