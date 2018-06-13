namespace RPG.Heroes.Abilities.WarriorAbilities.Offensive
{
    public class BleedDOT : OffensiveMeleeAbility
    {
        private const string AbilityName = "Bleed";
        private const AbilityType Type = AbilityType.OffensiveMelee;
        private const int AvailabilityLevel = 4;

        public BleedDOT()
        {
            BaseDamage = 2;
            EnergyCost = 20;
        }

        public int CalculateDamage(int strength)
        {
            return BaseDamage + (strength / 3);
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
    }
}
