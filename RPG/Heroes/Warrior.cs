using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.WarriorAbilities.CC;
using RPG.Heroes.Abilities.WarriorAbilities.Defensive;
using RPG.Heroes.Abilities.WarriorAbilities.Offensive;
using RPG.Heroes.CharacterTypes;
using RPG.NPC.HostileCreatures;
using System;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Warrior : MeleeRageCharacter
    {
        private const int MaxRage = 100;

        public Warrior(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Warrior;

            // Stats
            Attributes.Stamina = 13;
            Attributes.Strength = 10;
            Attributes.Agility = 8;
            Attributes.Intellect = 5;

            // Offense
            OffensiveStats.MinMelee = 3;
            OffensiveStats.MaxMelee = 6;
            OffensiveStats.SpellDamage = 0;

            // Defense
            DefensiveStats.Armor = 10;
            DefensiveStats.SpellResistance = 3;

            // Resources
            Stats.MaxHP = Attributes.Stamina * 10;
            Stats.HP = Stats.MaxHP;
            BaseRage = 0;
            CurrentRage = 0;

            // Abilities
            Abilities = new Dictionary<string, IAbility>()
            {
                { "Attack", new Attack(OffensiveStats.MinMelee, OffensiveStats.MaxMelee) },
                { "Strike", new Strike(OffensiveStats.MinMelee, OffensiveStats.MaxMelee) },
                { "Bleed",  new BleedDOT() },
                { "Block", new Block() },
                { "Tremble", new Tremble() }
            };
        }

        public override Mob ExecuteOffensiveMeleeRageAbility(IOffensiveMeleeRageAbility ability, Mob mob)
        {
            AbilityCheckState state = CanExecuteAbility(ability, MaxRage);

            if (state.CanExecute)
                mob = ExecuteAbility(ability, mob, state);
            else
                Console.WriteLine("\nYou don't have enough rage to execute that ability");

            return mob;
        }

        public override Mob ExecuteDefensiveMeleeAbility(IDefensiveMeleeAbility ability)
        {
            throw new NotImplementedException();
        }

        public override Mob ExecuteCCMeleeAbility(ICCMeleeAbility ability, Mob mob)
        {
            throw new NotImplementedException();
        }

        private void CalculateRageGain(Attack meleeAttack, bool wasCrit)
        {
            int rageGain;

            if (wasCrit)
                rageGain = meleeAttack.GetCritRageGain();
            else
                rageGain = meleeAttack.GetBaseRageGain();

            if (75 < CurrentRage)
                CurrentRage = MaxRage;
            else
                CurrentRage += rageGain;
        }
    }
}
