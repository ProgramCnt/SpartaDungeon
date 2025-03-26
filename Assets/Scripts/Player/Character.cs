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
    public int level;
    public int gold;
    public List<ItemData> inventory;
    public ItemData curEquipedItem;

    public Character()
    {
        maxHealth = 100;
        curHealth = maxHealth;
        attack = 35;
        defense = 40;
        criticalChance = 25f;
        gold = 0;
    }

    public Character(int curHealth, int maxHealth, int attack, int defense, int gold, float criticalChance)
    {
        this.curHealth = curHealth;
        this.maxHealth = maxHealth;
        this.attack = attack;
        this.defense = defense;
        this.criticalChance = criticalChance;
        this.gold = gold;
    }

    public virtual void OnDamage(int damage)
    {
        
    }

    public virtual void Heal(int healAmount)
    {

    }

    public virtual void AddItem(ItemData itemData)
    {
        inventory.Add(itemData);
        //if (inventory.Count > )
        //{

        //}
    }
}
