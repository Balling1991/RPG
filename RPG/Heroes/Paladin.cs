using RPG.Heroes.Abilities;
using RPG.NPC.HostileCreatures;
using System;

namespace RPG.Heroes
{
    public class Paladin : MeleeCharacter
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

            // Defence
            DefensiveStats.Armor = 5;
            DefensiveStats.SpellResistance = 8;
        }

        public override Mob ExecuteDefensiveMeleeAbility(IDefensiveMeleeAbility ability)
        {
            throw new NotImplementedException();
        }

        public override Mob ExecuteOffensiveMeleeAbility(IOffensiveMeleeRageAbility ability, Mob mob)
        {
            throw new NotImplementedException();
        }

        public override Mob ExecuteCCMeleeAbility(ICCMeleeAbility ability, Mob mob)
        {
            throw new NotImplementedException();
        }
    }
}
