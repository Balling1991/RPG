namespace RPG.Heroes.Abilities.HunterAbilities.Offensive
{
    public class InstantArrow : OffensiveMeleeAbility
    {
        private const string AbilityName = "Instant Arrow";
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

        public override string GetAbilityName()
        {
            throw new System.NotImplementedException();
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
