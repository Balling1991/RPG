﻿namespace RPG.Heroes.Abilities
{
    public interface IOffensiveSpellAbility : IAbility
    {
        int GetDamage();
        int GetManaCost();
    }
}