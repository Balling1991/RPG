namespace RPG.Heroes
{
    public class Priest : Character
    {
        public Priest(string name) : base(name)
        {
            name = Name;
            HeroClass = HeroClass.Priest;
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;
        }
    }
}
