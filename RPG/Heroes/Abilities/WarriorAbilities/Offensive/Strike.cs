namespace RPG.Heroes.Abilities.WarriorAbilities.Offensive
{
    public class Strike : OffensiveMeleeAbility
    {
        private const string AbilityName = "Strike";
        private const int AvailabilityLevel = 1;

        public Strike()
        {
            BaseDamage = 10;
            EnergyCost = 35;
        }

        public int CalculateDamage(int strength)
        {
            return BaseDamage + strength;
        }

        public override string GetAbilityName()
        {
            return AbilityName;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
