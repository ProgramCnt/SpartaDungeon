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

    public void SetPlayerInfo()         //�Ķ���� ���� �ʿ�
    {

    }

    public void SetGoldText(int goldAmount)
    {
        goldText.text = goldAmount.ToString();
    }

    public void OnStatusButtonClick()
    {
        ShowBackButton();
        //����â ����
    }

    public void OnInventoryButtonClick()
    {
        ShowBackButton();
        //�κ��丮â ����
    }

    public void OnBackButtonClick()
    {
        HideBackButton();
    }

    void ShowBackButton()
    {
        statusButton.gameObject.SetActive(true);
        inventoryButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(false);
    }

    void HideBackButton()
    {
        statusButton.gameObject.SetActive(false);
        inventoryButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(true);
    }
}
