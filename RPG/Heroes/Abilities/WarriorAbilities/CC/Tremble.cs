namespace RPG.Heroes.Abilities.WarriorAbilities.CC
{
    public class Tremble : ICCMeleeAbility
    {
        private const string AbilityName = "Tremble";
        private const int AvailabilityLevel = 15;
        private const int RageCost = 15;
        private const int Duration = 3;
        private const bool BreaksOnAttack = true;
        private const AbilityType Type = AbilityType.CCMelee;
        private const AbilityResourceKind ResourceKind = AbilityResourceKind.Consumer;

        public Tremble()
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

        public int GetDuration()
        {
            return Duration;
        }

        public bool GetBreakOnAttack()
        {
            return BreaksOnAttack;
        }
    }
}
