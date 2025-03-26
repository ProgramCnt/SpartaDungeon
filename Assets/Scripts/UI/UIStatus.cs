using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField]
    private Button StatusButton;

    [SerializeField]
    private List<StatData> statDatas;

    private void Start()
    {
        StatusButton.onClick.AddListener(UIManager.Instance._main.OnStatusButtonClick);
        UIManager.Instance.HideStatus();
    }

    public void SetCharacterStat(Character character)
    {
        statDatas[0].SetStatText("공격력");
        statDatas[1].SetStatText("방어력");
        statDatas[2].SetStatText("체력");
        statDatas[3].SetStatText("치명타");
        statDatas[0].SetStatValue(character.attack.ToString());
        statDatas[1].SetStatValue(character.defense.ToString());
        statDatas[2].SetStatValue(character.curHealth.ToString());
        statDatas[3].SetStatValue(character.criticalChance.ToString());
    }
}
