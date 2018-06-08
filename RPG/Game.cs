using RPG.GameFlow;
using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game : IGame
    {
        public bool _isPlaying;
        public List<Character> CharacterList;
        public CharacterFlow CharacterFlow;

        public Game()
        {
            _isPlaying = true;
            CharacterList = new List<Character>();
            CharacterFlow = new CharacterFlow(this, CharacterList);
        }

        public bool IsPlaying()
        {
            return _isPlaying;
        }

        public void SetIsPLaying(bool isPlaying)
        {
            _isPlaying = isPlaying;
        }

        public void MainMenu()
        {
            Console.WriteLine("\n** MAIN MENU **");
            Console.WriteLine("\n0: Quit");
            Console.WriteLine("1: Create new character");
            Console.WriteLine("2: Show characters");
            Console.Write("\nChoice: ");

            MainMenuChoices(Console.ReadKey().KeyChar.ToString());

        }

        public void MainMenuChoices(string choice)
        {
            Console.Clear();

            switch (choice)
            {
                case "0":
                    SetIsPLaying(false);
                    break;
                case "1":
                    var newCharacter = CharacterFlow.CreateNewCharacter();
                    CharacterFlow.SaveNewCharacter(newCharacter, CharacterList);
                    break;
                case "2":
                    CharacterFlow.ShowCharacterList(CharacterList);
                    break;
                default:
                    Console.WriteLine("\nPlease make a choice from the menu");
                    break;
            }
        }
    }
}
