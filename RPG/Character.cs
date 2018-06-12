using RPG.Heroes.Abilities;
using System.Collections.Generic;

namespace RPG
{
    public abstract class Character
    {
        // Basic
        public string Name { get; set; }
        protected HeroClass HeroClass { get; set; }
        private int Level { get; set; }
        private int Exp { get; set; }
        private int ExpToNextLvl { get; set; }
        protected int HP { get; set; }
        protected int MaxHP { get; set; }

        // Stats
        protected int Stamina { get; set; }
        protected int Strength { get; set; }
        protected int Agility { get; set; }
        protected int Intellect { get; set; }

        // Secondary stats
        private int CriticalStrike { get; set; }
        private int Haste { get; set; }
        private int Mastery { get; set; }

        // Offense
        protected int MinMelee { get; set; }
        protected int MaxMelee { get; set; }
        protected int SpellDamage { get; set; }

        // Defence
        protected int Armor { get; set; }
        protected int SpellResistance { get; set; }

        // Abilities
        protected Dictionary<string, IAbility> Abilities { get; set; }

        public Character(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                Name = name;
                Level = 1;
                Exp = 0;
                ExpToNextLvl = GetExpToNextLevel();

                CriticalStrike = 0;
                Haste = 0;
                Mastery = 0;
            }
        }

        // Getters

        // Basic
        public string GetName() => Name;
        public HeroClass GetHeroClass() => HeroClass;
        public int GetLevel() => Level;
        public int GetExp() => Exp;
        public int GetExpToNextLevel() => ((8 * Level) * (45 + (5 * Level)));
        public int GetHP() => HP;
        public int GetMaxHP() => MaxHP;

        // Stats
        public int GetStamina() => Stamina;
        public int GetStrength() => Strength;
        public int GetAgility() => Agility;
        public int GetIntellect() => Intellect;

        // Secondary stats
        public int GetCriticalStrike() => CriticalStrike;
        public int GetHaste() => Haste;
        public int GetMastery() => Mastery;

        // Offense
        public int GetMinMelee() => MinMelee;
        public int GetMaxMelee() => MaxMelee;
        public int GetSpellDamage() => SpellDamage;

        // Defence
        public int GetArmor() => Armor;
        public int GetSpellResistance() => SpellResistance;

        // Abilities
        public Dictionary<string, IAbility> GetAbilities() => Abilities;
        public IAbility GetAbility(string ability) => Abilities[ability];
    }
}