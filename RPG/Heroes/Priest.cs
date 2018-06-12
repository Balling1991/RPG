using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.PriestAbilities.Defensive;
using RPG.Heroes.Abilities.PriestAbilities.Offensive;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Priest : Character
    {
        public Priest(string name) : base(name)
        {
            // Basic
            name = Name;
            HeroClass = HeroClass.Priest;

            // Stats
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;

            // Offense
            MinMelee = 1;
            MaxMelee = 2;
            SpellDamage = 6;

            // Defence
            Armor = 5;
            SpellResistance = 5;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Lesser Heal", new LesserHeal() },
                { "Light Aura", new LightAuraHOT() },
                { "Orb of Light", new OrbOfLight() }
            };
        }
    }
}
