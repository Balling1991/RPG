﻿namespace RPG.Heroes.Abilities
{
    public abstract class OffensiveSpellAbility : IAbility
    {
        protected int BaseDamage { get; set; }
        protected int ManaCost { get; set; }

        public abstract string GetAbilityName();

        public abstract AbilityType GetAbilityType();

        public abstract int GetAvailabilityLevel();

        public int GetDamage()
        {
            return 0;
        }
    }
}