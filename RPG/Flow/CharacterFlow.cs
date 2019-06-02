using RPG.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Flow
{
    public class CharacterFlow
    {
        private readonly IGame _game;
        private readonly List<Character> _characterList;
        private GameFlow _gameFlow;
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
                Console.WriteLine();
            }

            for(int i = 0; i < characterList.Count; i++)
            {
                Console.WriteLine(i + ": " + characterList[i].Stats.Name + " - " + characterList[i].GetHeroClass() + " - lvl " + characterList[i].GetLevel());
            }

            Console.WriteLine("\n\nGo back... (space)");
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
            Console.WriteLine($"|---    Req. exp to lvl:  {character.GetExpToNextLevel()}");
            Console.WriteLine($"|---    HP:               {character.GetHP()}");
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
            Console.WriteLine($"|---    Min. melee dmg:   {character.GetMinMelee()}");
            Console.WriteLine($"|---    Max. melee dmg:   {character.GetMaxMelee()}");
            Console.WriteLine($"|---    Spell damage:     {character.GetSpellDamage()}");
            Console.WriteLine($"\n|--- DEFENSE:");
            Console.WriteLine($"|---    Armor:            {character.GetArmor()}");
            Console.WriteLine($"|---    Spell resistance: {character.GetSpellResistance()}");

            Console.WriteLine($"\n\nType 'P' if you wanna play this character!");

            Console.WriteLine("\nGo back...");
            var characterChoice = Console.ReadKey().KeyChar.ToString();

            if (characterChoice == "P" || characterChoice == "p")
            {
                GameFlow gameFlow;

                if (_gameFlow != null)
                {
                    _gameFlow.SetCharacter(character);
                    _gameFlow.GameMenu();
                }
                else
                {
                    gameFlow = new GameFlow(_game, this, character);
                    _gameFlow = gameFlow;
                    _gameFlow.GameMenu();
                }

                Console.Clear();
            } else {
                Console.Clear();
                ShowCharacterList(_characterList);
            }
        }
    }
}
