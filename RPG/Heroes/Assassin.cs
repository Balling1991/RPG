﻿using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.AssassinAbilities.Offensive;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Assassin : Character
    {
        public Assassin(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Assassin;

            // Stats
            Attributes.Stamina = 10;
            Attributes.Strength = 8;
            Attributes.Agility = 11;
            Attributes.Intellect = 7;

            // Offense
            OffensiveStats.MinMelee = 2;
            OffensiveStats.MaxMelee = 7;
            OffensiveStats.SpellDamage = 0;

            // Defence
            DefensiveStats.Armor = 7;
            DefensiveStats.SpellResistance = 4;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Stab", new Stab() },
                { "Venom Strike", new VenomStrike() }
            };
        }
    }
}
