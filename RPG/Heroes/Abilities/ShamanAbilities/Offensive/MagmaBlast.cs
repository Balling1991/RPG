namespace RPG.Heroes.Abilities.ShamanAbilities.Offensive
{
    public class MagmaBlast : IOffensiveSpellAbility
    {
        private const string AbilityName = "Magma Blast";
        private const int AvailabilityLevel = 1;
        private const int BaseDamage = 8;
        private const int ManaCost = 20;
        private const AbilityType Type = AbilityType.OffensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public MagmaBlast()
        {
        }

        public int CalculateDamage(int intellect, int agility)
        {
            return (BaseDamage + (intellect / 2) + (agility / 3));
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

        public int GetDamage()
        {
            return BaseDamage;
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
