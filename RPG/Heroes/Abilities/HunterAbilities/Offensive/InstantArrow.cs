namespace RPG.Heroes.Abilities.HunterAbilities.Offensive
{
    public class InstantArrow : OffensiveMeleeAbility
    {
        private const int AvailabilityLevel = 3;

        public InstantArrow()
        {
            BaseDamage = 12;
            EnergyCost = 45;
        }

        public int CalculateDamage(int agility)
        {
            return BaseDamage + agility;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
