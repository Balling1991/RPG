﻿using System;

namespace RPG.NPC.HostileCreatures
{
    public abstract class Mob
    {
        protected MobKind CreepKind { get; set; }
        protected int Level { get; set; }
        public int HP { get; set; }
        protected int MaxHP { get; set; }
        public bool IsCCed { get; set; }

        // Combat
        protected int MinMelee { get; set; }
        protected int MaxMelee { get; set; }

        // State
        private int LatestDamageDone { get; set; }

        public Character Attack(Character character)
        {
            Random random = new Random();
            int damage = random.Next(MinMelee, MaxMelee);

            character.Stats.HP -= damage;
            LatestDamageDone = damage;

            if (character.Stats.HP < 0)
                character.Stats.HP = 0;

            return character;
        }

        public void SetIsCCed(int rounds)
        {
            if (rounds > 0)
            {
                IsCCed = true;
            }
            else
            {
                IsCCed = false;
            }
        }

        // Getters
        public MobKind GetCreepKind() => CreepKind;
        public int GetLevel() => Level;
        public int GetHP() => HP;
        public int GetMaxHP() => MaxHP;
        public int GetMinMelee() => MinMelee;
        public int GetMaxMelee() => MaxMelee;
        public int GetLatestDamageDone() => LatestDamageDone;

    }
}
