namespace RPG.Heroes.Abilities.ShamanAbilities.Defensive
{
    public class ChantOfRain : DefensiveSpellAbility
    {
        private const string AbilityName = "Chant Of Rain";
        private const int AvailabilityLevel = 6;

        public ChantOfRain()
        {
            BaseArmor = 8;
            BaseResistance = 6;
            BaseHealing = 22;
            ManaCost = 40;
        }

        public int CalculateArmor(int intellect, int agility)
        {
            return BaseArmor + (intellect / 4) + (agility / 2);
        }

        public int CalculateResistance(int intellect)
        {
            return BaseResistance + intellect;
        }

        public int CalculateHealing(int intellect)
        {
            return BaseHealing + intellect;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }

        public override string GetAbilityName()
        {
            return AbilityName;
        }
    }
}
