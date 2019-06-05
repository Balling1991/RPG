namespace RPG.Heroes.Abilities
{
    public interface IOffensiveMeleeRageAbility : IAbility
    {
        int GetDamage();
        int GetRageGain(bool isCrit);
        int GetRageCost();
    }
}
