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
            name = Name;
            HeroClass = HeroClass.Warrior;

            // Stats
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;

            // Offense
            MinMelee = 2;
            MaxMelee = 6;
            SpellDamage = 0;

            // Defence
            Armor = 10;
            SpellResistance = 3;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Strike", new Strike() },
                { "Bleed",  new BleedDOT() }
            };
        }
    }
}
