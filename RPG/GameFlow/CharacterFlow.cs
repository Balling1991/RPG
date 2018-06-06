using RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG.GameFlow
{
    public class CharacterFlow
    {
        public static Character CreateNewCharacter()
        {
            Console.WriteLine("\nPlease enter the name of your character: ");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                Console.Clear();
                Console.WriteLine("Please enter a name to proceed.");
                CreateNewCharacter();
            }
                
            Console.Clear();
            Console.WriteLine("Please pick your hero class: ");

            ShowCharacterOptions(name);

            var heroClass = Console.ReadKey().KeyChar.ToString();
            Console.Clear();

            switch (heroClass)
            {
                case "0":
                    return new Mage(name);
                case "1":
                    return new Necromancer(name);
                case "2":
                    return new Priest(name);
                case "3":
                    return new Assassin(name);
                case "4":
                    return new Shaman(name);
                case "5":
                    return new Warlock(name);
                case "6":
                    return new Warrior(name);
                default:
                    Console.Clear();
                    Console.WriteLine("\nYou didn't pick a class. Try again.");
                    CreateNewCharacter();
                    break;
            }
            return null;
        }

        public static void ShowCharacterOptions(string name)
        {
            int menuCount = 0;

            foreach (HeroClass hero in Enum.GetValues(typeof(HeroClass)))
            {
                Console.WriteLine(menuCount + " - " + hero);
                menuCount++;
            }

            Console.WriteLine("--------------");
            Console.WriteLine("b - Cancel");
        }

        public static List<Character> SaveNewCharacter(Character character, List<Character> characterList)
        {
            if(character != null)
            {
                characterList.Add(character);
            }
            return characterList;
        }

        public static void ShowCharacterList(List<Character> CharacterList)
        {
            int characterCount = 0;

            if (!CharacterList.Any())
            {
                Console.WriteLine("You don't have any characters yet. Go make one...");
                Console.ReadKey();
                Console.Clear();
            }

            if(CharacterList.Any())
            {
                Console.WriteLine("--- YOUR CHARACTERS ---");
            }

            foreach (Character character in CharacterList)

            {
                Console.WriteLine(characterCount + ": " + character.Name + " - " + character.GetHeroClass() + " - lvl " + character.GetLevel());
                characterCount++;
            }
            Console.WriteLine("\nGo back...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
