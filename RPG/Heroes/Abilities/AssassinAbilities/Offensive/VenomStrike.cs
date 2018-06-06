namespace RPG.Heroes.Abilities.AssassinAbilities.Offensive
{
    public class VenomStrike : OffensiveMeleeAbility
    {
        private const int AvailabilityLevel = 4;

        public VenomStrike()
        {
            BaseDamage = 9;
            EnergyCost = 25;
        }

        public int CalculateDamage(int agility, int strength)
        {
            return BaseDamage + agility + (strength / 5);
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
