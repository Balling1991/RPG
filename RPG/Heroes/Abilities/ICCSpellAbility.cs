namespace RPG.Heroes.Abilities
{
    public interface ICCSpellAbility : IAbility
    {
        int GetManaCost();
        int GetDuration();
    }
}
