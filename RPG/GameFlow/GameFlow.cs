using System;

namespace RPG.GameFlow
{
    public class GameFlow
    {
        private readonly IGame _game;
        private readonly Character _character;
        public bool _isPlaying;

        public GameFlow(IGame game, Character character)
        {
            _game = game ?? throw new ArgumentNullException(nameof(game));
            _character = character ?? throw new ArgumentNullException(nameof(character));
        }

        public void GameMenu()
        {
            string GameMenuChoice;

            Console.WriteLine("\n** GAME MENU **");
            Console.WriteLine("\n0: Quit");
            Console.WriteLine("1: ");
            Console.WriteLine("2: Show characters");
            Console.Write("\nChoice: ");

            GameMenuChoice = Console.ReadKey().KeyChar.ToString();

            Console.Clear();

            switch (GameMenuChoice)
            {
                case "0":
                    _game.SetIsPLaying(false);
                    break;
                case "1":
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("\nPlease make a choice from the menu");
                    break;
            }
        }
    }
}
