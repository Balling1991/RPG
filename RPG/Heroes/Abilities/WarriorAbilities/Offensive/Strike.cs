﻿namespace RPG.Heroes.Abilities.WarriorAbilities.Offensive
{
    public class Strike : OffensiveMeleeAbility
    {
        private const string AbilityName = "Strike";
        private const AbilityType Type = AbilityType.OffensiveMelee;
        private const int AvailabilityLevel = 1;

        public Strike()
        {
            BaseDamage = 5;
            RageCost = 20;
        }

        public int CalculateDamage(int strength)
        {
            return BaseDamage + strength;
        }

        public override string GetAbilityName()
        {
            return AbilityName;
        }

        public override AbilityType GetAbilityType()
        {
            return Type;
        }

        public override int GetAvailabilityLevel()
        {
            return AvailabilityLevel;
        }

        public override int GetDamage()
        {
            throw new System.NotImplementedException();
        }
    }
}
