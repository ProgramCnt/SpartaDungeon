using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemData : ScriptableObject
{
    [Header("ItemInfo")]
    public string itemName;
    public Sprite ItemImage;

    [Header("Stat")]
    public int attack;
    public int defense;
    public float criticalChance;
}
