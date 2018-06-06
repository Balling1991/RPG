namespace RPG.Heroes.Abilities.AssassinAbilities.Offensive
{
    public class Stab : OffensiveMeleeAbility
    {
        private const int AvailabilityLevel = 1;

        public Stab()
        {
            BaseDamage = 5;
            EnergyCost = 35;
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
