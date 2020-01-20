using RPG.Heroes;
using System;

namespace RPG.Flow
{
    public class GameFlow : IGameFlow
    {
        private readonly IGameState _gameState;

        public GameFlow(IGameState gameState, Character character)
        {
            _gameState = gameState ?? throw new ArgumentNullException(nameof(gameState));
        }

        public void ChooseCharacter(Character character)
        {
            _gameState.SetCurrentCharacter(character);
        }
    }
}
