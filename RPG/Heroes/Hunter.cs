using RPG.Heroes.Abilities;
using RPG.NPC.HostileCreatures;

namespace RPG.Heroes
{
    public class Hunter : Character
    {
        public Hunter(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Hunter;

            // Stats
            Attributes.Stamina = 11;
            Attributes.Strength = 8;
            Attributes.Agility = 10;
            Attributes.Intellect = 12;

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
