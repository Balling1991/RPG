using RPG.Flow;
using RPG.Flow.Combat;
using RPG.Helpers;
using System;

namespace RPG.Navigation
{
    public class Navigation : INavigation
    {
        private readonly IGameState _game;
        private readonly Lazy<ICharacterManager> _characterManager;
        private readonly Lazy<ICombatFlow> _combatFlow;

        public Navigation(
            IGameState game,
            Lazy<ICharacterManager> characterManager,
            Lazy<ICombatFlow> combatFlow)
        {
            _game = game ?? throw new ArgumentNullException(nameof(game));
            _characterManager = characterManager ?? throw new ArgumentNullException(nameof(characterManager));
            _combatFlow = combatFlow ?? throw new ArgumentNullException(nameof(combatFlow));
        }

        public void PrintMainMenu()
        {
            string[] mainMenu = new string[] { "MAIN MENU", "Create new character", "Show characters", "Quit" };

            TextOutputHelper.FramePattern();
            TextOutputHelper.MenuPrinter(mainMenu);
            TextOutputHelper.BottomFramePattern();

            PrintMainMenuChoices(Console.ReadKey().KeyChar.ToString());
        }

        public void PrintMainMenuChoices(string choice)
        {
            Console.Clear();

            switch (choice)
            {
                case "1":
                    var newCharacter = _characterManager.Value.CreateNewCharacter();
                    _characterManager.Value.SaveNewCharacter(newCharacter);
                    break;
                case "2":
                    _characterManager.Value.PrintCharacterList();
                    break;
                case "Q":
                    _game.SetIsPlaying(false);
                    break;
                default:
                    Console.WriteLine("\nPlease make a choice from the menu");
                    break;
            }
        }

        public void PrintGameMenu()
        {
            string GameMenuChoice;
            Console.Clear();
            Console.WriteLine("\n** GAME MENU **");
            Console.WriteLine("\n0: Quit");
            Console.WriteLine("1: Character Overview");
            Console.WriteLine("2: Inventory");
            Console.WriteLine("3: Buy/sell");
            Console.WriteLine("4: Combat");
            Console.Write("\nChoice: ");

            GameMenuChoice = Console.ReadKey().KeyChar.ToString();

            Console.Clear();

            switch (GameMenuChoice)
            {
                case "0":
                    _game.SetIsPlaying(false);
                    break;
                case "1":
                    _characterManager.Value.PrintCharacterDetails(_game.GetCurrentCharacter());
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    _combatFlow.Value.Fight();
                    PrintGameMenu();
                    break;
                default:
                    Console.WriteLine("\nPlease make a choice from the menu");
                    break;
            }
        }
    }
}
