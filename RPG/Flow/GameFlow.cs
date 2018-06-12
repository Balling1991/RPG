using System;

namespace RPG.Flow
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
            Console.Clear();
            Console.WriteLine("\n** GAME MENU **");
            Console.WriteLine("\n0: Quit");
            Console.WriteLine("1: Character Overview");
            Console.WriteLine("2: Inventory");
            Console.WriteLine("3: Shop");
            Console.WriteLine("4: Battle");
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
                case "3":
                    break;
                case "4":
                    Fight();
                    break;
                default:
                    Console.WriteLine("\nPlease make a choice from the menu");
                    break;
            }
        }

        public void Fight()
        {
            string BattleMenuChoice;
            Console.Clear();
            Console.WriteLine("\n** FIGHT MENU **");
            Console.WriteLine("\n0: Quit");
            Console.WriteLine("1: Fight random mob");
            Console.WriteLine("2: Test ability get");
            Console.Write("\nChoice: ");

            BattleMenuChoice = Console.ReadKey().KeyChar.ToString();

            Console.Clear();

            switch (BattleMenuChoice)
            {
                case "0":
                    _game.SetIsPLaying(false);
                    break;
                case "1":
                    FightRandomMob();
                    break;
                case "2":
                    var ability =_character.GetAbility("Bleed");
                    Console.WriteLine($"You chose {ability.GetAbilityName()}");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("\nPlease make a choice from the menu");
                    break;
            }
        }

        public void FightRandomMob()
        {

        }
    }
}
