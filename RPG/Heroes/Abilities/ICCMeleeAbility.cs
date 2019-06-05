namespace RPG.Heroes.Abilities
{
    public interface ICCMeleeAbility : IAbility
    {
        int GetRageCost();
        int GetDuration();
    }
}
