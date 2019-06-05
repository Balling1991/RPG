using RPG.Heroes.Abilities;
using RPG.NPC.HostileCreatures;
using System;

namespace RPG.Heroes
{
    public abstract class SpellCharacter : Character
    {
        public SpellCharacter(string name)
            : base(name)
        {
        }

        public abstract Mob ExecuteOffensiveSpellAbility(IOffensiveSpellAbility ability, Mob mob);
        public abstract Mob ExecuteDefensiveSpellAbility(IDefensiveSpellAbility ability);
        public abstract Mob ExecuteCCSpellAbility(ICCSpellAbility ability, Mob mob);

        public Mob ExecuteAbility(IAbility ability, Mob mob)
        {
            switch (ability.GetAbilityType())
            {
                case AbilityType.OffensiveSpell:
                    return ExecuteOffensiveSpellAbility((IOffensiveSpellAbility)ability, mob);
                case AbilityType.DefensiveSpell:
                    return ExecuteDefensiveSpellAbility((IDefensiveSpellAbility)ability);
                case AbilityType.CCSpell:
                    return ExecuteCCSpellAbility((ICCSpellAbility)ability, mob);
                default:
                    Console.WriteLine("Ability not known");
                    return mob;
            }
        }
    }
}
