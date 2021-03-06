﻿using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.PriestAbilities.Defensive;
using RPG.Heroes.Abilities.PriestAbilities.Offensive;
using RPG.Heroes.CharacterTypes;
using RPG.NPC.HostileCreatures;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Priest : SpellManaCharacter
    {
        public Priest(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Priest;

            // Stats
            Attributes.Stamina = 11;
            Attributes.Strength = 8;
            Attributes.Agility = 10;
            Attributes.Intellect = 12;

            // Offense
            OffensiveStats.MinMelee = 1;
            OffensiveStats.MaxMelee = 2;
            OffensiveStats.SpellDamage = 6;

            // Defence
            DefensiveStats.Armor = 5;
            DefensiveStats.SpellResistance = 5;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Orb of Light", new OrbOfLight() },
                { "Lesser Heal", new LesserHeal() },
                { "Light Aura", new LightAuraHOT() }
            };
        }

        public override Mob ExecuteCCSpellAbility(ICCSpellAbility ability, Mob mob)
        {
            throw new System.NotImplementedException();
        }

        public override Mob ExecuteDefensiveSpellAbility(IDefensiveSpellAbility ability)
        {
            throw new System.NotImplementedException();
        }

        public override Mob ExecuteOffensiveSpellAbility(IOffensiveSpellAbility ability, Mob mob)
        {
            throw new System.NotImplementedException();
        }
    }
}
