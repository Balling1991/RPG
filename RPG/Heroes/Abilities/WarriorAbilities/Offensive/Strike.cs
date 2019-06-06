using System;

namespace RPG.Heroes.Abilities.WarriorAbilities.Offensive
{
    public class Strike : IOffensiveMeleeRageAbility
    {
        private const string AbilityName = "Strike";
        private const int AvailabilityLevel = 1;
        private const int BaseDamage = 5;
        private const int RageCost = 20;
        private const AbilityType Type = AbilityType.OffensiveRageMelee;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;
        private readonly int MinDmg;
        private readonly int MaxDmg;

        public Strike(int minDmg, int maxDmg)
        {
            MinDmg = minDmg;
            MaxDmg = maxDmg;
        }

        public int CalculateDamage(int strength)
        {
            return BaseDamage + strength;
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
            return AvailabilityLevel;
        }

        public int GetDamage()
        {
            Random random = new Random();
            int dmg = random.Next(MinDmg, MaxDmg);

            return BaseDamage + dmg;
        }

        public int GetRageCost() {
            return RageCost;
        }

        public int GetRageGain(bool isCrit)
        {
            return 0;
        }

        public AbilityResourceKind GetResourceKind() {
            return ResourceKind;
        }
    }
}
