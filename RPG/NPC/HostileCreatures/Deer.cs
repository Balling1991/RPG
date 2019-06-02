using System;

namespace RPG.NPC.HostileCreatures
{
    public class Deer : Mob
    {
        private readonly int BaseHp = 40;
        private readonly int MaxLevelToGenerate = 8;
        private readonly int MaxLevelDifference = 3;
        private int _playerLevel;

        public Deer(int playerLevel)
        {
            _playerLevel = playerLevel;
            CreepKind = MobKind.Deer;

            // Combat
            MinMelee = 3;
            MaxMelee = 10;

            GenerateDeer();
        }

        private void GenerateDeer()
        {
            Random rand = new Random();

            // Generate level and HP of deer
            if (_playerLevel < 3 && _playerLevel < MaxLevelToGenerate)
            {
                Level = rand.Next(_playerLevel, _playerLevel + MaxLevelDifference);
                MaxHP = Level * (BaseHp / 2);
            }
            else
            {
                Level = rand.Next(_playerLevel - MaxLevelDifference, _playerLevel + MaxLevelDifference);
                MaxHP = Level * (BaseHp / 2);
            }
        }
    }
}
