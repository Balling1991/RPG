using RPG.CharacterProps;
using RPG.Heroes.Abilities;
using RPG.NPC.HostileCreatures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public abstract class Character
    {
        public CharacterStats Stats { get; set; }
        public CharacterAttributes Attributes { get; set; }
        public SecondaryCharacterAttributes SecondaryAttributes { get; set; }
        public OffensiveCharacterStats OffensiveStats { get; set; }
        public DefensiveCharacterStats DefensiveStats { get; set; }
        public CharacterState CharacterState { get; set; }
        protected Dictionary<string, IAbility> Abilities { get; set; }

        public Character(string name)
        {
            Stats = new CharacterStats();
            Attributes = new CharacterAttributes();
            SecondaryAttributes = new SecondaryCharacterAttributes();
            OffensiveStats = new OffensiveCharacterStats();
            DefensiveStats = new DefensiveCharacterStats();
            CharacterState = new CharacterState();

            if (!string.IsNullOrEmpty(name))
            {
                Stats.Name = name;
                Stats.Level = 1;
                Stats.Exp = 0;
                Stats.ExpToNextLvl = GetExpToNextLevel();

                SecondaryAttributes.CriticalStrike = 0;
                SecondaryAttributes.Haste = 0;
                SecondaryAttributes.Mastery = 0;
            }
        }

        public void SetIsCCed(int rounds)
        {
            if(rounds > 0)
            {
                CharacterState.IsCCed = true;
            } else
            {
                CharacterState.IsCCed = false;
            }
        }

        public Mob ExecuteAbility(IAbility ability, Mob mob)
        {
            switch (ability.GetAbilityType())
            {
                case AbilityType.OffensiveMelee:
                    return ExecuteOffensiveMeleeAbility((IOffensiveMeleeRageAbility)ability, mob);
                case AbilityType.OffensiveSpell:
                    return ExecuteOffensiveSpellAbility((IOffensiveSpellAbility)ability, mob);
                case AbilityType.DefensiveMelee:
                    return ExecuteDefensiveMeleeAbility((IDefensiveMeleeAbility)ability);
                case AbilityType.DefensiveSpell:
                    return ExecuteDefensiveSpellAbility((IDefensiveSpellAbility)ability);
                case AbilityType.CCMelee:
                    return ExecuteCCMeleeAbility((ICCMeleeAbility)ability, mob);
                case AbilityType.CCSpell:
                    return ExecuteCCSpellAbility((ICCSpellAbility)ability, mob);
                default:
                    Console.WriteLine("Ability not known");
                    return mob;
            }
        }

        public void SetXP(int xpAwarded)
        {
            Stats.Exp += xpAwarded;
            CheckIfLeveledUp();
        }

        public void SetLatestAbilityUsed(IAbility ability) 
        {
            CharacterState.LatestAbilityUsed = ability;
        }

        private void CheckIfLeveledUp() {
        if (Stats.Exp > Stats.ExpToNextLvl)
            {
                Stats.Exp -= Stats.ExpToNextLvl;
                Stats.Level++;
                Console.WriteLine($"Congratulations! You have reached level {Stats.Level}!");
            }
        }

        // Getters

        // Basic
        public string GetName() => Stats.Name;
        public HeroClass GetHeroClass() => Stats.HeroClass;
        public int GetLevel() => Stats.Level;
        public int GetExp() => Stats.Exp;
        public int GetExpToNextLevel() => ((8 * Stats.Level) * (45 + (5 * Stats.Level)));
        public int GetHP() => Stats.HP;
        public int GetMaxHP() => Stats.MaxHP;

        // Stats
        public int GetStamina() => Attributes.Stamina;
        public int GetStrength() => Attributes.Strength;
        public int GetAgility() => Attributes.Agility;
        public int GetIntellect() => Attributes.Intellect;

        // Secondary stats
        public int GetCriticalStrike() => SecondaryAttributes.CriticalStrike;
        public int GetHaste() => SecondaryAttributes.Haste;
        public int GetMastery() => SecondaryAttributes.Mastery;

        // Offense
        public int GetMinMelee() => OffensiveStats.MinMelee;
        public int GetMaxMelee() => OffensiveStats.MaxMelee;
        public int GetSpellDamage() => OffensiveStats.SpellDamage;

        // Defence
        public int GetArmor() => DefensiveStats.Armor;
        public int GetSpellResistance() => DefensiveStats.SpellResistance;

        // Abilities
        public Dictionary<string, IAbility> GetAbilities() => Abilities;
        public IAbility GetAbility(string ability)
        {
            return Abilities.Single(c => c.Key.Equals(ability)).Value;
        }

        // State
        public int GetLatestDamageDone() => CharacterState.LatestDamageDone;
        public IAbility GetLatestAbilityUsed() => CharacterState.LatestAbilityUsed;
    }
}