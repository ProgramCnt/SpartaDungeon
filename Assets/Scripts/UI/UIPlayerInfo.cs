using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI : MonoBehaviour
{
    private Style _style;
    [SerializeField]
    private TextMeshProUGUI _nameText;
    [SerializeField]
    private TextMeshProUGUI _levelValueText;
    [SerializeField]
    private Image levelBar;
    [SerializeField]
    private TextMeshProUGUI _description;

    public void SetCharacterName(string name)
    {
        _nameText.text = name;
    }

    public void SetLevelText(int level)
    {
        _levelValueText.text = level.ToString();
    }

    public void SetLevelBar(int experience, int experienceAmount)
    {
        levelBar.fillAmount = (float)experience / experienceAmount;
    }

    public void SetDescription(string description)
    {
        _description.text = description;
    }
}
