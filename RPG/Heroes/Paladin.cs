using RPG.Heroes.Abilities;
using RPG.Heroes.CharacterTypes;
using RPG.NPC.HostileCreatures;
using System;

namespace RPG.Heroes
{
    public class Paladin : MeleeManaCharacter
    {
        public Paladin(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Paladin;

            // Stats
            Attributes.Stamina = 12;
            Attributes.Strength = 9;
            Attributes.Agility = 8;
            Attributes.Intellect = 10;

            // Offense
            OffensiveStats.MinMelee = 1;
            OffensiveStats.MaxMelee = 2;
            OffensiveStats.SpellDamage = 8;

            // Defense
            DefensiveStats.Armor = 5;
            DefensiveStats.SpellResistance = 8;
        }

        public override Mob ExecuteCCSpellAbility(ICCSpellAbility ability, Mob mob)
        {
            throw new NotImplementedException();
        }

        public override Mob ExecuteDefensiveSpellAbility(IDefensiveSpellAbility ability)
        {
            throw new NotImplementedException();
        }

        public override Mob ExecuteOffensiveSpellAbility(IOffensiveSpellAbility ability, Mob mob)
        {
            throw new NotImplementedException();
        }
    }
}
