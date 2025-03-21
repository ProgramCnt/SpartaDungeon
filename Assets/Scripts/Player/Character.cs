using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int curHealth;
    public int maxHealth;
    public int attack;
    public int defense;
    public float criticalChance;
    public int experience;
    public int experienceAmount = 10;
    public int level;
    public string description;
    public int gold;

    public Character()
    {
        curHealth = 100;
        maxHealth = 100;
        attack = 35;
        defense = 40;
        criticalChance = 25f;
        experience = 0;
        level = 1;
        gold = 0;
    }

    public Character(int curHealth, int maxHealth, int attack, int defense, int experience, int level, int experienceAmount, int gold, float criticalChance, string description)
    {
        this.curHealth = curHealth;
        this.maxHealth = maxHealth;
        this.attack = attack;
        this.defense = defense;
        this.criticalChance = criticalChance;
        this.experience = experience;
        this.level = level;
        this.description = description;
        this.experienceAmount = experienceAmount;
        this.gold = gold;
    }

    public virtual void OnDamage(int damage)
    {
        
    }

    public virtual void Heal(int healAmount)
    {

    }
}
