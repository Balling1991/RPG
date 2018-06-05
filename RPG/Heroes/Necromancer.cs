namespace RPG.Heroes
{
    public class Necromancer : Character
    {
        public Necromancer(string name) : base(name)
        {
            name = Name;
            HeroClass = HeroClass.Necromancer;
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;
        }
    }
}