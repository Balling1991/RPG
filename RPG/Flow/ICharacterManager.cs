namespace RPG.Flow
{
    public interface ICharacterManager
    {
        Character CreateNewCharacter();
        void SaveNewCharacter(Character character);
        void PrintCharacterOptions();
        void PrintCharacterList();
        void PrintCharacterDetails(Character character);
    }
}
