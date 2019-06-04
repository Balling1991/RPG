using RPG.Heroes.Abilities;

namespace RPG.CharacterProps
{
    public class CharacterState
    {
        public bool IsCCed { get; set; }
        public int LatestDamageDone { get; set; }
        public IAbility LatestAbilityUsed { get; set; }
    }
}
