using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatData : MonoBehaviour
{
    [SerializeField]
    private Image _statImage;
    [SerializeField]
    private TextMeshProUGUI _statNameText;
    [SerializeField]
    private TextMeshProUGUI _statValue;

    public void SetStatImage()
    {

    }

    public void SetStatText(string name)
    {
        _statNameText.text = name;
    }

    public void SetStatValue(string value)
    {
        _statValue.text = value;
    }
}
