using RPG.Heroes.Abilities;
using RPG.NPC.HostileCreatures;

namespace RPG.Heroes.CharacterTypes
{
    public abstract class MeleeRageCharacter : Character
    {
        public MeleeRageCharacter(string name)
            : base(name)
        {
        }

        public override abstract Mob ExecuteOffensiveMeleeRageAbility(IOffensiveMeleeRageAbility ability, Mob mob);
        public override abstract Mob ExecuteDefensiveMeleeAbility(IDefensiveMeleeAbility ability);
        public override abstract Mob ExecuteCCMeleeAbility(ICCMeleeAbility ability, Mob mob);

        public AbilityCheckState CanExecuteAbility(IOffensiveMeleeRageAbility ability, int maxRage)
        {
            AbilityCheckState state = new AbilityCheckState();

            if (ability.GetResourceKind() == AbilityResourceKind.Gainer)
            {
                state.CanExecute = true;
                state.ResourceKind = AbilityResourceKind.Gainer;
            }

            if (CurrentRage < ability.GetRageCost())
            {
                state.CanExecute = false;
                state.ResourceKind = AbilityResourceKind.Consumer;
            }
            state.CanExecute = true;
            state.ResourceKind = AbilityResourceKind.Consumer;

            return state;
        }

        public Mob ExecuteAbility(IOffensiveMeleeRageAbility ability, Mob mob, AbilityCheckState state)
        {
            var damage = ability.GetDamage();

            mob.SetHp(mob.HP - damage);
            CharacterState.LatestDamageDone = damage;
            CharacterState.LatestAbilityUsed = ability;
            UpdateRage(ability, state);

            return mob;
        }

        public void UpdateRage(IOffensiveMeleeRageAbility ability, AbilityCheckState state)
        {
            // Can't crit yet
            if (state.ResourceKind == AbilityResourceKind.Gainer)
                CurrentRage += ability.GetRageGain(false);

            if (state.CanExecute)
                CurrentRage -= ability.GetRageCost();
        }

        public int BaseRage { get; protected set; }
        public int CurrentRage { get; protected set; }
    }
}
