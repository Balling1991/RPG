namespace RPG.Heroes.Abilities
{
    public interface IDefensiveMeleeAbility : IAbility
    {
        int GetRageCost();
        int GetArmor();
    }
}
