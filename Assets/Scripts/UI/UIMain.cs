using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonArea;

    public TextMeshProUGUI goldText;
    public Button statusButton;
    public Button inventoryButton;
    public Button backButton;

    [SerializeField]
    private PlayerInfoUI playerInfoUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init()
    {
        buttonArea.SetActive(true);

    }

    public void SetPlayerInfo(Character character)
    {
        playerInfoUI.SetCharacterName(character.name);
        playerInfoUI.SetLevelBar(character.experience, character.experienceAmount);
        playerInfoUI.SetLevelText(character.level);
        playerInfoUI.SetDescription(character.description);
    }

    public void SetGoldText(int goldAmount)
    {
        goldText.text = goldAmount.ToString();
    }

    public void OnStatusButtonClick()
    {
        ShowBackButton();
        UIManager.Instance.ShowStatus();
    }

    public void OnInventoryButtonClick()
    {
        ShowBackButton();
        UIManager.Instance.ShowInventory();
    }

    public void OnBackButtonClick()
    {
        HideBackButton();
        UIManager.Instance.HideStatus();
        UIManager.Instance.HideInventory();
    }

    void ShowBackButton()
    {
        statusButton.gameObject.SetActive(false);
        inventoryButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(true);
    }

    void HideBackButton()
    {
        statusButton.gameObject.SetActive(true);
        inventoryButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(false);
    }
}
