namespace RPG.Heroes
{
    public class Hunter : Character
    {
        public Hunter(string name) : base(name)
        {
            // Basic
            name = Name;
            HeroClass = HeroClass.Hunter;

            // Stats
            Stamina = 11;
            Strength = 8;
            Agility = 10;
            Intellect = 12;

            // Offense
            MinMelee = 1;
            MaxMelee = 2;
            SpellDamage = 8;

            // Defence
            Armor = 5;
            SpellResistance = 8;
        }
    }
}
