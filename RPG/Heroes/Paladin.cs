using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Heroes
{
    public class Paladin : Character
    {
        public Paladin(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Paladin;

            // Stats
            Attributes.Stamina = 12;
            Attributes.Strength = 9;
            Attributes.Agility = 8;
            Attributes.Intellect = 10;

            // Offense
            OffensiveStats.MinMelee = 1;
            OffensiveStats.MaxMelee = 2;
            OffensiveStats.SpellDamage = 8;

            // Defence
            DefensiveStats.Armor = 5;
            DefensiveStats.SpellResistance = 8;
        }
    }
}
