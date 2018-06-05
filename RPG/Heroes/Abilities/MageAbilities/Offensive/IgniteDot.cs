namespace RPG.Heroes.Abilities.MageAbilities.Offensive
{
    public class IgniteDot : OffensiveSpellAbility
    {
        private const int AvailabilityLevel = 4;

        public IgniteDot()
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
