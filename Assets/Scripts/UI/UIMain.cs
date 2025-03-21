using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public Button statusButton;
    public Button inventoryButton;
    public Button backButton;

    [SerializeField]
    private PlayerInfoUI playerInfoUI;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(OnBackButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init()
    {

    }

    public void SetPlayerInfo(Character character)
    {

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
