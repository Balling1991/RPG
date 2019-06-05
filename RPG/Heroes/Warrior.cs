using RPG.Heroes.Abilities;
using RPG.Heroes.Abilities.WarriorAbilities.Offensive;
using RPG.NPC.HostileCreatures;
using System;
using System.Collections.Generic;

namespace RPG.Heroes
{
    public class Warrior : MeleeCharacter
    {
        private const int MaxRage = 100;

        public Warrior(string name) : base(name)
        {
            // Basic
            Stats.Name = name;
            Stats.HeroClass = HeroClass.Warrior;

            // Stats
            Attributes.Stamina = 13;
            Attributes.Strength = 8;
            Attributes.Agility = 10;
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
                { "Bleed",  new BleedDOT() }
            };
        }

        public override Mob ExecuteOffensiveMeleeAbility(IOffensiveMeleeRageAbility ability, Mob mob)
        {
            bool canExecute = CanExecuteAbility(ability);

            if (canExecute)
                mob = ExecuteAbility(ability, mob);
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

        private bool CanExecuteAbility(IOffensiveMeleeRageAbility ability)
        {
            if (ability is Attack)
                return true;

            if (CurrentRage < ability.GetRageCost())
                return false;
            else if ((MaxRage - ability.GetRageCost()) < ability.GetRageCost())
                return false;
            else
            return true;
        }

        private Mob ExecuteAbility(IOffensiveMeleeRageAbility ability, Mob mob)
        {
            var damage = ability.GetDamage();

            mob.SetHp(mob.HP - damage);
            CharacterState.LatestDamageDone = damage;
            CharacterState.LatestAbilityUsed = ability;
            UpdateRage(ability);

            return mob;
        }

        private void UpdateRage(IOffensiveMeleeRageAbility ability)
        {
            if (ability is Attack)
                CurrentRage += ability.GetRageGain(false);

            if (CanExecuteAbility(ability))
            {
                CurrentRage -= ability.GetRageCost();
            }
        }

        private void SetRageGain(Attack meleeAttack, bool wasCrit)
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

        public int BaseRage { get; private set; }
        public int CurrentRage { get; private set; }
    }
}
