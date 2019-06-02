using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.ShamanAbilities.Defensive;
using RPG.Heroes.Abilities.ShamanAbilities.Offensive;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Shaman : Character
    {
        public Shaman(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Shaman;

            // Stats
            Attributes.Stamina = 11;
            Attributes.Strength = 8;
            Attributes.Agility = 10;
            Attributes.Intellect = 12;

            // Offense
            OffensiveStats.MinMelee = 2;
            OffensiveStats.MaxMelee = 5;
            OffensiveStats.SpellDamage = 5;

            // Defence
            DefensiveStats.Armor = 7;
            DefensiveStats.SpellResistance = 5;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Magma Blast", new MagmaBlast() },
                { "Chant of Rain", new ChantOfRain() }
            };
        }
    }
}