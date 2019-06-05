namespace RPG.Heroes.Abilities.MageAbilities.Offensive
{
    public class Fireball : IOffensiveSpellAbility
    {
        private const string AbilityName = "Fireball";
        private const int AvailabilityLevel = 1;
        private const int BaseDamage = 10;
        private const int ManaCost = 5;
        private const AbilityType Type = AbilityType.OffensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public Fireball()
        {
        }

        public int CalculateDamage(int intellect)
        {
            return BaseDamage + intellect;
        }

        public string GetAbilityName()
        {
            return AbilityName;
        }

        public AbilityType GetAbilityType()
        {
            return Type;
        }

        public int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }

        public int GetManaCost()
        {
            return ManaCost;
        }

        public AbilityResourceKind GetResourceKind()
        {
            return ResourceKind;
        }
    }
}
