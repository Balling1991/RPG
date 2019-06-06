using RPG.Heroes.Abilities;
using RPG.NPC.HostileCreatures;

namespace RPG.Heroes.CharacterTypes
{
    public abstract class SpellManaCharacter : Character
    {
        public SpellManaCharacter(string name)
            : base(name)
        {
        }

        public override abstract Mob ExecuteOffensiveSpellAbility(IOffensiveSpellAbility ability, Mob mob);
        public override abstract Mob ExecuteDefensiveSpellAbility(IDefensiveSpellAbility ability);
        public override abstract Mob ExecuteCCSpellAbility(ICCSpellAbility ability, Mob mob);
    }
}
