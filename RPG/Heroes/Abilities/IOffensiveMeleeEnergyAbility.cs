namespace RPG.Heroes.Abilities
{
    public interface IOffensiveMeleeEnergyAbility : IAbility
    {
        int GetDamage();
        int GetEnergyGain();
        int GetEnergyCost();
    }
}
