namespace RPG.Heroes.Abilities.AssassinAbilities.Offensive
{
    public class VenomStrike : OffensiveMeleeAbility
    {
        private const string AbilityName = "Venom Strike";
        private const AbilityType Type = AbilityType.OffensiveMelee;
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
