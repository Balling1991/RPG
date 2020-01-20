namespace RPG
{
    public interface IGameState
    {
        bool IsPlaying();
        void SetIsPlaying(bool isPlaying);
        Character GetCurrentCharacter();
        void SetCurrentCharacter(Character character);
    }
}
