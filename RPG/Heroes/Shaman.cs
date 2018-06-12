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
            name = Name;
            HeroClass = HeroClass.Shaman;

            // Stats
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;

            // Offense
            MinMelee = 2;
            MaxMelee = 5;
            SpellDamage = 5;

            // Defence
            Armor = 7;
            SpellResistance = 5;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Magma Blast", new MagmaBlast() },
                { "Chant of Rain", new ChantOfRain() }
            };
        }
    }
}