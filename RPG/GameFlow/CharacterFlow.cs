using RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG.GameFlow
{
    public class CharacterFlow
    {
        private readonly IGame _game;
        private readonly List<Character> _characterList;
        public bool _isPlaying;

        public CharacterFlow(IGame game, List<Character> characterList)
        {
            _game = game ?? throw new ArgumentNullException(nameof(game));
            _characterList = characterList ?? throw new ArgumentNullException(nameof(characterList));
        }

        public Character CreateNewCharacter()
        {
            Console.Write("\nPlease enter the name of your character: ");
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

            Console.Write("\nClass nr.: ");

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

        public List<Character> SaveNewCharacter(Character character, List<Character> characterList)
        {
            if(character != null)
            {
                characterList.Add(character);
            }
            return characterList;
        }

        public void ShowCharacterList(List<Character> characterList)
        {
            if (!characterList.Any())
            {
                Console.WriteLine("You don't have any characters yet. Go make one...");
                Console.ReadKey();
                Console.Clear();
            }

            if(characterList.Any())
            {
                Console.WriteLine("--- YOUR CHARACTERS ---");
            }

            for(int i = 0; i < characterList.Count; i++)
            {
                Console.WriteLine(i + ": " + characterList[i].Name + " - " + characterList[i].GetHeroClass() + " - lvl " + characterList[i].GetLevel());
            }

            Console.WriteLine("\n\nPick the character you want to inspect:");
            Console.WriteLine("\nGo back...");
            Console.Write("\nCharacter nr: ");

            var characterFromList = Console.ReadKey().KeyChar.ToString();

            if (int.TryParse(characterFromList, out int characterNumber))
            {
                ShowCharacterDetails(characterList[characterNumber]);
            } else
            {
                Console.Clear();
            }
        }

        public void ShowCharacterDetails(Character character)
        {
            Console.Clear();
            Console.WriteLine($"\n!---------- CHARACTER ----------");
            Console.WriteLine($"\n Name: {character.GetName()} ||| Class: {character.GetHeroClass()} ||| Lvl: {character.GetLevel()}");
            Console.WriteLine($"\n!---------- STATS ----------");
            Console.WriteLine($"\n|--- BASIC:");
            Console.WriteLine($"|---    Exp.:             {character.GetExp()}");
            Console.WriteLine($"|---    Exp. to level up: {character.GetExpToNextLevel()}");
            Console.WriteLine($"|---    HP:               {character.GetMaxHP()}");
            Console.WriteLine($"\n|--- ATTRIBUTES:");
            Console.WriteLine($"|---    Stamina:          {character.GetStamina()}");
            Console.WriteLine($"|---    Strength:         {character.GetStrength()}");
            Console.WriteLine($"|---    Agility:          {character.GetAgility()}");
            Console.WriteLine($"|---    Intellect:        {character.GetIntellect()}");
            Console.WriteLine($"\n|--- SECONDARY:");
            Console.WriteLine($"|---    Critical Strike:  {character.GetCriticalStrike()}");
            Console.WriteLine($"|---    Haste:            {character.GetHaste()}");
            Console.WriteLine($"|---    Mastery:          {character.GetMastery()}");
            Console.WriteLine($"\n|--- OFFENSE:");
            Console.WriteLine($"|---    Min. melee dmg:   {character.GetCriticalStrike()}");
            Console.WriteLine($"|---    Max. melee dmg:   {character.GetHaste()}");
            Console.WriteLine($"|---    Spell damage:     {character.GetMastery()}");
            Console.WriteLine($"\n|--- DEFENSE:");
            Console.WriteLine($"|---    Armor:            {character.GetCriticalStrike()}");
            Console.WriteLine($"|---    Spell resistance: {character.GetHaste()}");

            Console.WriteLine($"\n\nType 'P' if you wanna play this character!");

            Console.WriteLine("\nGo back...");
            var characterChoice = Console.ReadKey().KeyChar.ToString();

            if (characterChoice == "P" || characterChoice == "p")
            {
                GameFlow gameFlow = new GameFlow(_game, character);
                gameFlow.GameMenu();
                Console.Clear();
            } else {
                Console.Clear();
                ShowCharacterList(_characterList);
            }
        }
    }
}
