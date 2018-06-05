namespace RPG.Heroes
{
    public class Warrior : Character
    {
        public Warrior(string name) : base(name)
        {
            name = Name;
            HeroClass = HeroClass.Warrior;
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;
        }
    }
}
