using RPG.Heroes.Abilities;
using RPG.Heroes.CharacterTypes;
using RPG.Navigation;
using RPG.NPC.HostileCreatures;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RPG.Flow.Combat
{
    public class CombatFlow : ICombatFlow
    {
        private readonly IGameState _gameState;
        private readonly Lazy<INavigation> _navigation;
        private bool _isFighting = false;

        public CombatFlow(
            IGameState gameState,
            Lazy<INavigation> navigation)
        {
            _gameState = gameState ?? throw new ArgumentNullException(nameof(gameState));
            _navigation = navigation ?? throw new ArgumentNullException(nameof(navigation));
        }

        public void Fight()
        {
            string CombatMenuChoice;
            Console.Clear();
            Console.WriteLine("\n** FIGHT MENU **");
            Console.WriteLine("\n0: Go back ..");
            Console.WriteLine("1: Find mob");
            Console.WriteLine("2: Find mob pack");
            Console.WriteLine("3: Find elite mob");
            Console.WriteLine("4: Find elite pack");

            Console.Write("\nChoice: ");

            CombatMenuChoice = Console.ReadKey().KeyChar.ToString();

            Console.Clear();

            switch (CombatMenuChoice)
            {
                case "0":
                    _navigation.Value.PrintGameMenu();
                    break;
                case "1":
                    var mob = GenerateRandomMob();
                    FightRandomMob(mob);
                    _navigation.Value.PrintGameMenu();
                    break;
                default:
                    Console.WriteLine("\nPlease make a choice from the menu");
                    break;
            }
        }

        public Mob GenerateRandomMob()
        {
            Random randomNumber = new Random();
            var mobNumber = randomNumber.Next(0, 0);

            // Needs work
            switch (mobNumber)
            {
                case 0:
                    return new Deer(_gameState.GetCurrentCharacter().GetLevel());
                default:
                    return new Deer(_gameState.GetCurrentCharacter().GetLevel());
            }
        }

        public void FightRandomMob(Mob mob)
        {
            _isFighting = true;
            IAbility abilityToExecute;
            List<string> abilityList = new List<string>(_gameState.GetCurrentCharacter().GetAbilities().Keys);
            Random random = new Random();
            int rounds = 0;
            bool playerHadATurn = false;
            bool mobHadATurn = false;

            var playerTurn = random.Next(1, 2);
            mob.SetHp(mob.GetMaxHP());

            string FightMenuChoice;

            while (_isFighting)
            {
                if (CheckCombatRound(playerHadATurn, mobHadATurn))
                {
                    rounds += 1;
                    playerHadATurn = false;
                    mobHadATurn = false;
                }

                if (playerTurn == 1) {
                    Console.Clear();
                    Console.WriteLine("\n** COMBAT MENU **");

                    StatsAndAbilityTextOutput(abilityList, mob);

                    FightMenuChoice = Console.ReadKey().KeyChar.ToString();

                    AttackTextOutput();

                    bool correctInput = int.TryParse(FightMenuChoice, out int choice);

                    if (!correctInput)
                    {
                        Console.WriteLine("You didn't press an ability, so we basic attacked for you");
                    }

                    abilityToExecute = _gameState.GetCurrentCharacter().GetAbility(abilityList[choice]);
                    if(_gameState.GetCurrentCharacter() is MeleeRageCharacter)
                        mob = _gameState.GetCurrentCharacter().ExecuteAbility(abilityToExecute, mob);

                    bool isInCombat = CheckIfStillInCombat(mob);

                    if (isInCombat)
                    {
                        Console.WriteLine($"You hit the {mob.GetCreepKind()} for {_gameState.GetCurrentCharacter().GetLatestDamageDone()} damage");
                    }
                    playerTurn = 2;
                    playerHadATurn = true;
                }
                else if (playerTurn == 2)
                {
                    Console.WriteLine($"\n{mob.GetCreepKind()} is attacking!");
                    Thread.Sleep(1000);

                    AttackTextOutput();

                    mob.Attack(_gameState.GetCurrentCharacter());

                    bool isInCombat = CheckIfStillInCombat(mob);

                    if (isInCombat)
                    {
                        Console.WriteLine($"The {mob.GetCreepKind()} hit you for {mob.GetLatestDamageDone()} damage");
                        Console.WriteLine("\nContinue..");
                        Console.ReadKey();
                    }
                    playerTurn = 1;
                    mobHadATurn = true;
                }
            }
        }

        private void AttackTextOutput()
        {
            Console.WriteLine("\nAttacking.");
            Thread.Sleep(1000);
            Console.WriteLine("Attacking..");
            Thread.Sleep(1000);
            Console.WriteLine("------------------------");
        }

        private void StatsAndAbilityTextOutput(List<string> abilityList, Mob mob)
        {
            for (int i = 0; i < abilityList.Count; i++)
            {
                Console.WriteLine($"{i}: {abilityList[i]}");
            }
            Console.WriteLine($"\n{_gameState.GetCurrentCharacter().GetName()} - {_gameState.GetCurrentCharacter().GetHeroClass()} - Lvl. {_gameState.GetCurrentCharacter().GetLevel()}");
            Console.WriteLine($"HP: {_gameState.GetCurrentCharacter().GetHP()} | {_gameState.GetCurrentCharacter().GetResourceType().ToString()}: {_gameState.GetCurrentCharacter().GetResourceAmount()}");
            Console.WriteLine($"\n{mob.GetCreepKind()} HP: {mob.HP}");
            Console.Write("\nChoice: ");
        }

        private bool CheckIfStillInCombat(Mob mob)
        {
            if (_gameState.GetCurrentCharacter().GetHP() <= 0)
            {
                _isFighting = false;
                // For testing
                _gameState.GetCurrentCharacter().Stats.HP = _gameState.GetCurrentCharacter().Stats.MaxHP;
                //
                Console.Clear();
                Console.WriteLine($"The {mob.GetCreepKind()} killed you with {mob.GetHP()} hp left");
                Console.WriteLine("\nClick a button to go back ..");
                Console.ReadKey();
                return false;
            }

            if (mob.GetHP() <= 0)
            {
                _isFighting = false;

                // For testing
                _gameState.GetCurrentCharacter().Stats.HP = _gameState.GetCurrentCharacter().Stats.MaxHP;
                //
                int xpAwarded = CalculateXPAwarded(mob);

                Console.WriteLine($"\nYou defeated a lvl {mob.GetLevel()} {mob.GetCreepKind()} and was awarded {xpAwarded} xp");
                Console.WriteLine($"{_gameState.GetCurrentCharacter().GetExp()} + {xpAwarded}/{_gameState.GetCurrentCharacter().GetExpToNextLevel()} xp to next lvl");
                _gameState.GetCurrentCharacter().SetXP(xpAwarded);
                Console.WriteLine("Go back ..");
                Console.ReadKey();
                return false;
            }
            return true;
        }

        private int CalculateXPAwarded(Mob mob)
        {
            int characterLevel = _gameState.GetCurrentCharacter().GetLevel();
            int mobLevel = mob.GetLevel();
            int baseXP = (characterLevel * 5) + 45;

            if (characterLevel == mobLevel)
            {
                return baseXP;
            }
            else if (characterLevel < mobLevel)
            {
                return (int)Math.Round(baseXP * (1 + 0.05 * (mobLevel - characterLevel)));
            }
            else
            {
                int zd = CalculateZDValue(characterLevel);
                return (int)Math.Round(baseXP * (1 - (characterLevel - mobLevel) / (double)zd));
            }
        }

        private int CalculateZDValue(int charLevel)
        {
            switch (charLevel)
            {
                case int n when (1 <= n && n <= 7):
                    return 5;
                case int n when (8 <= n && n <= 9):
                    return 6;
                case int n when (10 <= n && n <= 11):
                    return 7;
                case int n when (12 <= n && n <= 15):
                    return 8;
                case int n when (16 <= n && n <= 19):
                    return 9;
                case int n when (20 <= n && n <= 29):
                    return 11;
                case int n when (30 <= n && n <= 39):
                    return 12;
                case int n when (40 <= n && n <= 44):
                    return 13;
                case int n when (45 <= n && n <= 49):
                    return 14;
                case int n when (50 <= n && n <= 54):
                    return 15;
                case int n when (55 <= n && n <= 59):
                    return 16;
                default:
                    return 0;
            }
        }

        private bool CheckCombatRound(bool playerHadATurn, bool mobHadATurn) {
            if (playerHadATurn && mobHadATurn)
                return true;
            
            return false;
        }
    }
}
