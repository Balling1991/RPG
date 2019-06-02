namespace RPG.CharacterProps
{
    public class CharacterStats
    {
        public string Name { get; set; }
        public HeroClass HeroClass { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int ExpToNextLvl { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
    }
}
