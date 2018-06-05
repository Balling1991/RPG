using RPG.Heroes.Abilities.MageAbilities;
using RPG.Heroes.Abilities.MageAbilities.Defensive;
using RPG.Heroes.Abilities.MageAbilities.Offensive;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Mage : Character
    {
        private List<IAbility> Abilities;

        public Mage(string name) : base(name)
        {
            // Basic
            name = Name;
            HeroClass = HeroClass.Mage;

            // Stats
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;

            // Offense
            MinMelee = 1;
            MaxMelee = 2;
            SpellDamage = 8;

            // Defence
            Armor = 5;
            SpellResistance = 8;

            // Offensive Abilities
            Abilities = new List<IAbility>()
            {
                new Fireball(),
                new IgniteDot(),
                new ManaShield()
            };
        }
    }
}
