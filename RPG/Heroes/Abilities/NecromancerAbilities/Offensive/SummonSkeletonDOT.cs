namespace RPG.Heroes.Abilities.NecromancerAbilities.Offensive
{
    public class SummonSkeletonDOT : OffensiveSpellAbility
    {
        private const int AvailabilityLevel = 1;

        public SummonSkeletonDOT()
        {
            BaseDamage = 2;
            ManaCost = 10;
        }

        public int CalculateDamage(int intellect, int strength)
        {
            return BaseDamage + (intellect / 2) + (strength / 2);
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
