namespace RPG.Heroes.Abilities.PriestAbilities.Offensive
{
    public class OrbOfLight : OffensiveSpellAbility
    {
        private const string AbilityName = "Orb Of Light";
        private const int GetAvailablityLevel = 1;

        public OrbOfLight()
        {
            BaseDamage = 6;
            ManaCost = 25;
        }

        public int CalculateDamage(int intellect)
        {
            return (int)(BaseDamage + (intellect * 1.5));
        }

        public override string GetAbilityName()
        {
            return AbilityName;
        }

        public override int GetAvailabilityLevel()
        {
            return GetAvailablityLevel;
        }
    }
}
