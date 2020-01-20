using RPG.Heroes;
using RPG.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG.Flow
{
    public class CharacterManager : ICharacterManager
    {
        private readonly IGameState _gameState;
        private readonly Lazy<INavigation> _navigation;
        private readonly IGameFlow _gameFlow;
        private readonly List<Character> _characterList;
        public bool _isPlaying;

        public CharacterManager(
            IGameState gameState,
            Lazy<INavigation> navigation,
            IGameFlow gameFlow,
            List<Character> characterList)
        {
            _gameState = gameState ?? throw new ArgumentNullException(nameof(gameState));
            _navigation = navigation ?? throw new ArgumentNullException(nameof(navigation));
            _gameFlow = gameFlow ?? throw new ArgumentNullException(nameof(gameFlow));
            _characterList = characterList ?? throw new ArgumentNullException(nameof(characterList));
        }

        public Character CreateNewCharacter()
        {
            Console.WriteLine("\n<<<------ CHARACTER CREATION ------>>>");
            Console.Write("\nCharacter name: ");
            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                Console.Clear();
                Console.WriteLine("Please enter a name to proceed.");
                CreateNewCharacter();
            }

            Console.WriteLine("\nHero class: ");

            PrintCharacterOptions();

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

        public void SaveNewCharacter(Character character)
        {
            _characterList.Add(character);
        }

        public void PrintCharacterOptions()
        {
            int menuCount = 0;

            Console.WriteLine();

            foreach (HeroClass hero in Enum.GetValues(typeof(HeroClass)))
            {
                Console.WriteLine(menuCount + " - " + hero);
                menuCount++;
            }
        }

        public void PrintCharacterList()
        {
            if (!_characterList.Any())
            {
                Console.WriteLine("You don't have any characters yet. Go make one...");
                Console.ReadKey();
                Console.Clear();
            }

            if(_characterList.Any())
            {
                Console.WriteLine("<<<------ YOUR CHARACTERS ------>>>");
                Console.WriteLine();
            }

            for(int i = 0; i < _characterList.Count; i++)
            {
                Console.WriteLine(i + ": " + _characterList[i].Stats.Name + " - " + _characterList[i].GetHeroClass() + " - lvl " + _characterList[i].GetLevel());
            }

            Console.WriteLine("\n\nGo back... (space)");
            Console.Write("\nCharacter nr: ");

            var characterFromList = Console.ReadKey().KeyChar.ToString();

            if (int.TryParse(characterFromList, out int characterNumber))
            {
                PrintCharacterDetails(_characterList[characterNumber]);
            } else
            {
                Console.Clear();
            }
        }

        public void PrintCharacterDetails(Character character)
        {
            Console.Clear();
            Console.WriteLine($"\n!<<<------ CHARACTER ------>>>");
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
                _gameFlow.ChooseCharacter(character);
                _navigation.Value.PrintGameMenu();

                Console.Clear();
            }
            else
            {
                Console.Clear();
                PrintCharacterList();
            }       
        }
    }
}
