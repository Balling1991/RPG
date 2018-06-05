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

        public int GetLevel()
        {
            return Level;
        }

        public int GetExp()
        {
            return Exp;
        }

        public int GetExpToNextLevel()
        {
            return ((8 * Level) * (45 + (5 * Level)));
        }

        public HeroClass GetHeroClass()
        {
            return HeroClass;
        }
    }
}