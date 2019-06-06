namespace RPG.Heroes.Abilities.WarriorAbilities.Defensive
{
    public class Block : IDefensiveMeleeAbility
    {
        private const string AbilityName = "Block";
        private const int AvailabilityLevel = 12;
        private const int RageCost = 33;
        private const int BaseArmor = 25;
        private const AbilityType Type = AbilityType.DefensiveMelee;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public Block()
        {
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

        public AbilityResourceKind GetResourceKind()
        {
            return ResourceKind;
        }

        public int GetRageCost()
        {
            return RageCost;
        }

        public int GetArmor()
        {
            return BaseArmor;
        }
    }
}
