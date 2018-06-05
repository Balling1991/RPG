namespace RPG.Heroes
{
    public class Rogue : Character
    {
        public Rogue(string name) : base(name)
        {
            name = Name;
            HeroClass = HeroClass.Rogue;
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;
        }
    }
}
