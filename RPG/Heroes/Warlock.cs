using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.WarlockAbilities.Defensive;
using RPG.Heroes.Abilities.WarlockAbilities.Offensive;
using RPG.NPC.HostileCreatures;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Warlock : Character
    {
        public Warlock(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Warlock;

            // Stats
            Attributes.Stamina = 11;
            Attributes.Strength = 8;
            Attributes.Agility = 10;
            Attributes.Intellect = 12;

            // Offense
            OffensiveStats.MinMelee = 1;
            OffensiveStats.MaxMelee = 2;
            OffensiveStats.SpellDamage = 10;

            // Defense
            DefensiveStats.Armor = 6;
            DefensiveStats.SpellResistance = 6;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Nether Bolt", new NetherBolt() },
                { "Dark Pact", new DarkPact() }
            };
        }
    }
}