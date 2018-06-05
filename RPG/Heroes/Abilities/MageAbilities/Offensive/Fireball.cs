﻿namespace RPG.Heroes.Abilities.MageAbilities.Offensive
{
    public class Fireball : OffensiveSpellAbility
    {
        private const int AvailabilityLevel = 1;

        public Fireball()
        {
            BaseDamage = 10;
            ManaCost = 5;
        }

        public int CalculateDamage(int intellect)
        {
            return BaseDamage + intellect;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }
    }
}