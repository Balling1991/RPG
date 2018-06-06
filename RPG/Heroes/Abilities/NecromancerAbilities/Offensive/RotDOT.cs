namespace RPG.Heroes.Abilities.NecromancerAbilities.Offensive
{
    public class RotDOT : OffensiveSpellAbility
    {
        private const int AvailabilityLevel = 4;

        public RotDOT()
        {
            BaseDamage = 2;
            ManaCost = 6;
        }

        public int CalculateDamage(int intellect)
        {
            return BaseDamage + (intellect / 5);
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
