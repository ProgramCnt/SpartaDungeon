using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Rarity
{
    Normal,
    Rare,
    Epic,
    Legendary
}

//나중에 적용시켜볼 칭호시스템
public class Style : MonoBehaviour
{
    Rarity rarity;
    string titleName;
    Color styleColor;
}
