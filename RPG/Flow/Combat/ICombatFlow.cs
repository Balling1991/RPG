using RPG.NPC.HostileCreatures;

namespace RPG.Flow.Combat
{
    public interface ICombatFlow
    {
        void Fight();
        // Only for testing
        Mob GenerateRandomMob();
        // Only for testing
        void FightRandomMob(Mob mob);
    }
}
