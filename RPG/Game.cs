using RPG.GameFlow;
using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game
    {
        public bool IsPlaying;
        public string MainMenuChoice;
        public bool IsCharacterPicked;
        public List<Character> CharacterList;

        public Game()
        {
            IsPlaying = true;
            CharacterList = new List<Character>();
        }

        public void MainMenu()
        {
            Console.WriteLine("\n** MAIN MENU **");
            Console.WriteLine("0: Quit");
            Console.WriteLine("1: Create new character");
            Console.WriteLine("2: Show characters");

            MainMenuChoice = Console.ReadKey().KeyChar.ToString();

            Console.Clear();

            switch(MainMenuChoice)
            {
                case "0":
                    IsPlaying = false;
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
