using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.WarriorAbilities.Offensive;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Warrior : Character
    {
        public Warrior(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Warrior;

            // Stats
            Attributes.Stamina = 13;
            Attributes.Strength = 8;
            Attributes.Agility = 10;
            Attributes.Intellect = 5;

            // Offense
            OffensiveStats.MinMelee = 3;
            OffensiveStats.MaxMelee = 6;
            OffensiveStats.SpellDamage = 0;

            // Defense
            DefensiveStats.Armor = 10;
            DefensiveStats.SpellResistance = 3;

            // Resources
            Stats.MaxHP = Attributes.Stamina * 10;
            Stats.HP = Stats.MaxHP;
            BaseRage = 0;
            CurrentRage = 0;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Attack", new Attack(OffensiveStats.MinMelee, OffensiveStats.MaxMelee) },
                { "Strike", new Strike() },
                { "Bleed",  new BleedDOT() }
            };
        }

        //public int CalculaterageRegain()
        //{

        //}

        public int BaseRage { get; private set; }
        public int CurrentRage { get; private set; }
    }
}
