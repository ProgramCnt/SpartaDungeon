using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int curHealth { get; private set; }
    public int maxHealth { get; private set; }
    public int attack { get; private set; }
    public int defense { get; private set; }
    public float criticalChance { get; private set; }

    public Character()
    {
        curHealth = 100;
        maxHealth = 100;
        attack = 35;
        defense = 40;
        criticalChance = 25f;
    }

    public Character(int curHealth, int maxHealth, int attack, int defense, float criticalChance)
    {
        this.curHealth = curHealth;
        this.maxHealth = maxHealth;
        this.attack = attack;
        this.defense = defense;
        this.criticalChance = criticalChance;
    }

    public virtual void OnDamage(int damage)
    {
        
    }

    public virtual void Heal(int healAmount)
    {

    }
}
