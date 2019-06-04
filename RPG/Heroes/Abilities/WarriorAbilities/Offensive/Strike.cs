namespace RPG.Heroes.Abilities.WarriorAbilities.Offensive
{
    public class Strike : OffensiveMeleeAbility
    {
        private const string AbilityName = "Strike";
        private const AbilityType Type = AbilityType.OffensiveMelee;
        private const int AvailabilityLevel = 1;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Gainer;
        private int MinDmg;
        private int MaxDmg;
        private int BaseDamage;
        private int RageCost;

        public Strike(int minDmg, int maxDmg)
        {
            MinDmg = minDmg;
            MaxDmg = maxDmg;
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
            Random random = new Random();
            int dmg = random.Next(MinDmg, MaxDmg);

            return BaseDamage + dmg;
        }

        public override int GetRageCost() {
            return RageCost;
        }

        public override AbilityResourceKind GetResourceKind() {
            return ResourceKind;
        }
    }
}
