namespace RPG.Heroes
{
    public class Warlock : Character
    {
        public Warlock(string name) : base(name)
        {
            name = Name;
            HeroClass = HeroClass.Warlock;
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;
        }
    }
}