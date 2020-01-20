using RPG.Navigation;
using System;

namespace RPG
{
    public class Application
    {
        private readonly IGameState _gameState;
        private readonly IVisuals _visuals;
        private readonly INavigation _navigation;

        public Application(
            IGameState gameState,
            IVisuals visuals,
            INavigation navigation)
        {
            _gameState = gameState ?? throw new ArgumentNullException(nameof(gameState));
            _visuals = visuals ?? throw new ArgumentNullException(nameof(visuals));
            _navigation = navigation ?? throw new ArgumentNullException(nameof(navigation));
        }

        public void Run()
        {
            WindowHelper.DisallowWindowResize();
            _visuals.DrawSplash();
            _gameState.SetIsPlaying(true);

            while (_gameState.IsPlaying())
            {
                _navigation.PrintMainMenu();
            }
        }
    }
}
