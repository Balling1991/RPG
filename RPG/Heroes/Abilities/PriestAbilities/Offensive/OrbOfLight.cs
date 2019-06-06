namespace RPG.Heroes.Abilities.PriestAbilities.Offensive
{
    public class OrbOfLight : IOffensiveSpellAbility
    {
        private const string AbilityName = "Orb Of Light";
        private const int GetAvailablityLevel = 1;
        private const int BaseDamage = 6;
        private const int ManaCost = 25;
        private const AbilityType Type = AbilityType.OffensiveSpell;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public OrbOfLight()
        {
        }

        public int CalculateDamage(int intellect)
        {
            return (int)(BaseDamage + (intellect * 1.5));
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
            return GetAvailablityLevel;
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
