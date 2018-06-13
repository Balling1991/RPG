namespace RPG.Heroes.Abilities.WarlockAbilities.Offensive
{
    public class NetherBolt : OffensiveSpellAbility
    {
        private const string AbilityName = "Netherbolt";
        private const AbilityType Type = AbilityType.OffensiveSpell;
        private const int AvailabilityLevel = 1;

        public NetherBolt()
        {
            BaseDamage = 13;
            ManaCost = 40;
        }

        public int CalculateDamage(int intellect)
        {
            return BaseDamage + intellect;
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
