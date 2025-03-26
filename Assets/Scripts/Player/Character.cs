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
        inventory = new List<ItemData> ();
    }

    public Character(int curHealth, int maxHealth, int attack, int defense, float criticalChance, List<ItemData> inventory)
    {
        this.curHealth = curHealth;
        this.maxHealth = maxHealth;
        this.attack = attack;
        this.defense = defense;
        this.criticalChance = criticalChance;
        if (inventory != null)
        {
            this.inventory = inventory;
        }
        else
        {
            this.inventory = new List<ItemData>();
        }
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
    }
}
