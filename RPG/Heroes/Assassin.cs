using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.AssassinAbilities.Offensive;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Assassin : Character
    {
        public Assassin(string name) : base(name)
        {
            // Basic
            name = Name;
            HeroClass = HeroClass.Assassin;

            // Stats
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;

            // Offense
            MinMelee = 1;
            MaxMelee = 7;
            SpellDamage = 0;

            // Defence
            Armor = 7;
            SpellResistance = 4;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Stab", new Stab() },
                { "Venom Strike", new VenomStrike() }
            };
        }
    }
}
