using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.MageAbilities.Defensive;
using RPG.Heroes.Abilities.MageAbilities.Offensive;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Mage : Character
    {
        public Mage(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Mage;

            // Stats
            Attributes.Stamina = 8;
            Attributes.Strength = 8;
            Attributes.Agility = 7;
            Attributes.Intellect = 12;

            // Offense
            OffensiveStats.MinMelee = 1;
            OffensiveStats.MaxMelee = 2;
            OffensiveStats.SpellDamage = 8;

            // Defence
            DefensiveStats.Armor = 5;
            DefensiveStats.SpellResistance = 8;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Fireball", new Fireball() },
                { "Ignite", new IgniteDOT() },
                { "Mana Shield", new ManaShield() }
            };
        }
    }
}
