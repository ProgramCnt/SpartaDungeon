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

//���߿� ������Ѻ� Īȣ�ý���
public class Style : MonoBehaviour
{
    Rarity rarity;
    string titleName;
    Color styleColor;
}
