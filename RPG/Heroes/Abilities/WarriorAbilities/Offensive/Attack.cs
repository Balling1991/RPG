using System;

namespace RPG.Heroes.Abilities.WarriorAbilities.Offensive
{
    public class Attack : OffensiveMeleeAbility
    {
        private const string AbilityName = "Attack";
        private const AbilityType Type = AbilityType.OffensiveMelee;
        private const int AvailabilityLevel = 1;

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
    }
}
