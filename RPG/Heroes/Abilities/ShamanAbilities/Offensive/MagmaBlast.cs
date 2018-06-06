namespace RPG.Heroes.Abilities.ShamanAbilities.Offensive
{
    public class MagmaBlast : OffensiveSpellAbility
    {
        private const int AvailabilityLevel = 1;

        public MagmaBlast()
        {
            BaseDamage = 8;
            ManaCost = 20;
        }

        public int CalculateDamage(int intellect, int agility)
        {
            return (BaseDamage + (intellect / 2) + (agility / 3));
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
