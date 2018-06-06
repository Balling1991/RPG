using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.WarlockAbilities.Defensive;
using RPG.Heroes.Abilities.WarlockAbilities.Offensive;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Warlock : Character
    {
        private Dictionary<string, IAbility> Abilities;

        public Warlock(string name) : base(name)
        {
            // Basic
            name = Name;
            HeroClass = HeroClass.Warlock;

            // Stats
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;

            // Offense
            MinMelee = 1;
            MaxMelee = 2;
            SpellDamage = 10;

            // Defense
            Armor = 6;
            SpellResistance = 6;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Nether Bolt", new NetherBolt() },
                { "Dark Pact", new DarkPact() }
            };
        }
    }
}