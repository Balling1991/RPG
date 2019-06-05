using System;

namespace RPG.Heroes.Abilities.WarriorAbilities.Offensive
{
    public class Attack : IOffensiveMeleeRageAbility
    {
        private const string AbilityName = "Attack";
        private const int AvailabilityLevel = 1;
        private const int BaseRageGain = 23;
        private const int CritRageGain = 30;
        private const AbilityType Type = AbilityType.OffensiveMelee;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Gainer;

        private readonly int MinMelee;
        private readonly int MaxMelee;

        public Attack(int minMelee, int maxMelee)
        {
            MinMelee = minMelee;
            MaxMelee = maxMelee;
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
            return random.Next(MinMelee, MaxMelee);
        }

        public int GetBaseRageGain() {
            return BaseRageGain;
        }

        public int GetCritRageGain() {
            return CritRageGain;
        }

        public AbilityResourceKind GetResourceKind()
        {
            return ResourceKind;
        }

        public int GetRageGain(bool isCrit)
        {
            if(isCrit)
                return CritRageGain;
            return BaseRageGain;
        }

        public int GetRageCost()
        {
            return 0;
        }
    }
}
