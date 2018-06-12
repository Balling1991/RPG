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
            name = Name;
            HeroClass = HeroClass.Necromancer;

            // Stats
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;

            // Offense
            MinMelee = 1;
            MaxMelee = 3;
            SpellDamage = 6;

            // Defence
            Armor = 6;
            SpellResistance = 7;

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