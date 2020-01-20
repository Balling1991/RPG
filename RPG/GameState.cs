using System;

namespace RPG
{
    public class GameState : IGameState
    {
        private bool _isPlaying;
        private Character _character;

        public bool IsPlaying()
        {
            return _isPlaying;
        }

        public void SetIsPlaying(bool isPlaying)
        {
            _isPlaying = isPlaying;
        }

        public Character GetCurrentCharacter()
        {
            return _character;
        }

        public void SetCurrentCharacter(Character character)
        {
            _character = character ?? throw new ArgumentNullException(nameof(character));
        }
    }
}
