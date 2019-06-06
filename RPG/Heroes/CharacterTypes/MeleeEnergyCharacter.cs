using RPG.Heroes.Abilities;
using RPG.NPC.HostileCreatures;

namespace RPG.Heroes.CharacterTypes
{
    public abstract class MeleeEnergyCharacter : Character
    {
        public MeleeEnergyCharacter(string name)
            : base(name)
        {
        }

        public override abstract Mob ExecuteOffensiveMeleeEnergyAbility(IOffensiveMeleeEnergyAbility ability, Mob mob);
        public override abstract Mob ExecuteDefensiveMeleeAbility(IDefensiveMeleeAbility ability);
        public override abstract Mob ExecuteCCMeleeAbility(ICCMeleeAbility ability, Mob mob);
    }
}
