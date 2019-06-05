using RPG.Heroes.Abilities;
using RPG.NPC.HostileCreatures;
using System;

namespace RPG.Heroes
{
    public abstract class MeleeCharacter : Character
    {
        public MeleeCharacter(string name)
            : base(name)
        {
        }

        public abstract Mob ExecuteOffensiveMeleeAbility(IOffensiveMeleeRageAbility ability, Mob mob);
        public abstract Mob ExecuteDefensiveMeleeAbility(IDefensiveMeleeAbility ability);
        public abstract Mob ExecuteCCMeleeAbility(ICCMeleeAbility ability, Mob mob);

        public Mob ExecuteAbility(IAbility ability, Mob mob)
        {
            switch (ability.GetAbilityType())
            {
                case AbilityType.OffensiveMelee:
                    return ExecuteOffensiveMeleeAbility((IOffensiveMeleeRageAbility)ability, mob);
                case AbilityType.DefensiveMelee:
                    return ExecuteDefensiveMeleeAbility((IDefensiveMeleeAbility)ability);
                case AbilityType.CCMelee:
                    return ExecuteCCMeleeAbility((ICCMeleeAbility)ability, mob);
                default:
                    Console.WriteLine("Ability not known");
                    return mob;
            }
        }
    }
}
