using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.NecromancerAbilities.Defensive;
using RPG.Heroes.Abilities.NecromancerAbilities.Offensive;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Necromancer : Character
    {
        public Necromancer(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Necromancer;

            // Stats
            Attributes.Stamina = 11;
            Attributes.Strength = 8;
            Attributes.Agility = 10;
            Attributes.Intellect = 12;

            // Offense
            OffensiveStats.MinMelee = 1;
            OffensiveStats.MaxMelee = 3;
            OffensiveStats.SpellDamage = 6;

            // Defence
            DefensiveStats.Armor = 6;
            DefensiveStats.SpellResistance = 7;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Summon Skeleton", new SummonSkeletonDOT() },
                { "Rot", new RotDOT() },
                { "Bone Shield", new BoneShield() }
            };
        }
    }
}