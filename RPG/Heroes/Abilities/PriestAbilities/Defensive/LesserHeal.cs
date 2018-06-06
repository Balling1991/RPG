﻿namespace RPG.Heroes.Abilities.PriestAbilities.Defensive
{
    public class LesserHeal : DefensiveSpellAbility
    {
        private const int AvailabilityLevel = 4;

        public LesserHeal()
        {
            BaseArmor = 0;
            BaseResistance = 0;
            BaseHealing = 45;
            ManaCost = 30;
        }

        public int CalculateHealing(int intellect)
        {
            return BaseResistance + intellect;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}