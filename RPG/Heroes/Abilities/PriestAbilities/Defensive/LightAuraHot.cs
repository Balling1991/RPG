namespace RPG.Heroes.Abilities.PriestAbilities.Defensive
{
    public class LightAuraHOT : DefensiveSpellAbility
    {
        private const int AvailabilityLevel = 10;

        public LightAuraHOT()
        {
            BaseArmor = 2;
            BaseResistance = 0;
            BaseHealing = 8;
            ManaCost = 45;
        }

        public int CalculateArmor(int intellect)
        {
            return BaseArmor + (intellect / 5);
        }

        public int CalculateHealing(int intellect)
        {
            return BaseHealing + (intellect / 2);
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
