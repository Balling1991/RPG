namespace RPG.Combat
{
    public interface IExecuteAbility
    {
        void ExecuteOffensiveAbility(Character character, string ability);
        void ExecuteDefensiveAbility(Character character, string ability);
    }
}
