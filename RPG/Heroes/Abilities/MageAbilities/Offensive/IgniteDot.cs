namespace RPG.Heroes.Abilities.MageAbilities.Offensive
{
    public class IgniteDOT : OffensiveSpellAbility
    {
        private const string AbilityName = "Ignite";
        private const AbilityType Type = AbilityType.OffensiveSpell;
        private const int AvailabilityLevel = 4;

        public IgniteDOT()
        {
            BaseDamage = 2;
            ManaCost = 6;
        }

        public int CalculateDamage(int intellect)
        {
            return BaseDamage + (intellect / 5);
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
