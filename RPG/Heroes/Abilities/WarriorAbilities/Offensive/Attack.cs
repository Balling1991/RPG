using System;

namespace RPG.Heroes.Abilities.WarriorAbilities.Offensive
{
    public class Attack : OffensiveMeleeAbility
    {
        private const string AbilityName = "Attack";
        private const AbilityType Type = AbilityType.OffensiveMelee;
        private const int AvailabilityLevel = 1;
        private const int BaseRageGain = 23;
        private const int CritRageGain = 30;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Gainer;

        private readonly int MinMelee;
        private readonly int MaxMelee;

        public Attack(int minMelee, int maxMelee)
        {
            MinMelee = minMelee;
            MaxMelee = maxMelee;
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
            Random random = new Random();
            return random.Next(MinMelee, MaxMelee);
        }

        public int GetBaseRageGain() {
            return BaseRageGain;
        }

        public int GetCritRageGain() {
            return CritRageGain;
        }
    }
}
