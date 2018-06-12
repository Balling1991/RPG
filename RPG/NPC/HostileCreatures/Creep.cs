using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.NPC.HostileCreatures
{
    public abstract class Creep
    {
        protected CreepKind CreepKind { get; set; }
        private int Level { get; set; }
        protected int HP { get; set; }
        protected int MaxHP { get; set; }

        public Creep()
        {

        }

        // Getters
        public CreepKind GetCreepKind() => CreepKind;
        public int GetLevel() => Level;
        public int GetHP() => HP;
        public int GetMaxHP() => MaxHP;

    }
}
