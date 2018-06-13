namespace RPG.Heroes.Abilities.NecromancerAbilities.Offensive
{
    public class RotDOT : OffensiveSpellAbility
    {
        private const string AbilityName = "Rot";
        private const AbilityType Type = AbilityType.OffensiveSpell;
        private const int AvailabilityLevel = 4;

        public RotDOT()
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
