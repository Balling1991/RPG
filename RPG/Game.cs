using RPG.Flow;
using RPG.Heroes;
using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game : IGame
    {
        public bool _isPlaying;
        public List<Character> _characterList;
        public CharacterFlow _characterFlow;

        public Game()
        {
            _isPlaying = true;
            _characterList = new List<Character>();
            _characterFlow = new CharacterFlow(this, _characterList);
        }

        public bool IsPlaying()
        {
            return _isPlaying;
        }

        public void SetIsPlaying(bool isPlaying)
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
                    SetIsPlaying(false);
                    break;
                case "1":
                    var newCharacter = _characterFlow.CreateNewCharacter();
                    _characterFlow.SaveNewCharacter(newCharacter, _characterList);
                    break;
                case "2":
                    _characterFlow.ShowCharacterList(_characterList);
                    break;
                default:
                    Console.WriteLine("\nPlease make a choice from the menu");
                    break;
            }
        }
    }
}
