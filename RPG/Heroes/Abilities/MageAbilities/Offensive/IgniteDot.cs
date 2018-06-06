﻿namespace RPG.Heroes.Abilities.MageAbilities.Offensive
{
    public class IgniteDOT : OffensiveSpellAbility
    {
        private const int AvailabilityLevel = 4;

        public IgniteDOT()
        {
            BaseDamage = 2;
            ManaCost = 6;
        }

        public int CalculateDamage(int intellect)
        {
            return BaseDamage + (intellect / 5);
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}
