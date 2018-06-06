﻿namespace RPG.Heroes.Abilities.MageAbilities.Defensive
{
    public class ManaShield : DefensiveSpellAbility
    {
        private const int AvailabilityLevel = 6;

        public ManaShield()
        {
            BaseArmor = 5;
            BaseResistance = 15;
            BaseHealing = 0;
            ManaCost = 30;
        }

        public int CalculateResistance(int intellect)
        {
            return BaseResistance + intellect;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
