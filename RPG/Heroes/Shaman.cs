namespace RPG.Heroes
{
    public class Shaman : Character
    {
        public Shaman(string name) : base(name)
        {
            name = Name;
            HeroClass = HeroClass.Shaman;
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;
        }
    }
}