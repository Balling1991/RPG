namespace RPG.Heroes.Abilities.HunterAbilities.Offensive
{
    public class InstantArrow : OffensiveMeleeAbility
    {
        private const string AbilityName = "Instant Arrow";
        private const AbilityType Type = AbilityType.OffensiveMelee;
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
            return AbilityName;
        }

        public override AbilityType GetAbilityType()
        {
            return Type;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }

        public override int GetDamage()
        {
            throw new System.NotImplementedException();
        }
    }
}
