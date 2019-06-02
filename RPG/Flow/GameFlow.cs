using RPG.Flow.Combat;
using System;

namespace RPG.Flow
{
    public class GameFlow
    {
        private readonly IGame _game;
        private readonly CharacterFlow _charFlow;
        private Character _character;
        private CombatFlow _combat;

        public GameFlow(IGame game, CharacterFlow charFlow, Character character)
        {
            _game = game ?? throw new ArgumentNullException(nameof(game));
            _charFlow = charFlow ?? throw new ArgumentNullException(nameof(charFlow));
            _character = character ?? throw new ArgumentNullException(nameof(character));
            _combat = new CombatFlow(this, character);
        }

        public void SetCharacter(Character character)
        {
            _character = character ?? throw new ArgumentNullException(nameof(character));
        }

        public void GameMenu()
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
                    _game.SetIsPLaying(false);
                    break;
                case "1":
                    _charFlow.ShowCharacterDetails(_character);
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    _combat.Fight();
                    GameMenu();
                    break;
                default:
                    Console.WriteLine("\nPlease make a choice from the menu");
                    break;
            }
        }

        
    }
}
