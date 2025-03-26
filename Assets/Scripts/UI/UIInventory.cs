using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private Button InventoryButton;

    [SerializeField]
    private GameObject slotPrefab;

    [SerializeField]
    private GameObject itemSlotList;

    [SerializeField]
    private TextMeshProUGUI itemCountText;
    
    private UISlot[] slots;
    private int itemCount = 0;

    public List<ItemData> addItems; //임시 아이템 추가용 리스트

    private void Awake()
    {
        slots = itemSlotList.GetComponentsInChildren<UISlot>();
    }

    private void Start()
    {
        InventoryButton.onClick.AddListener(UIManager.Instance._main.OnInventoryButtonClick);
        Init();
    }

    public void Init()
    {
        UpdateInventorySlot();
        UIManager.Instance.HideInventory();

        for (int i = 0; i < addItems.Count; i++)            //임시로 아이템 추가
        {
            slots[i].itemData = addItems[i];
        }

        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].itemData != null)
            {
                itemCount++;
                slots[i].RefreshUI();
            }
        }
        UpdateItemCountText(itemCount);
    }

    public void UpdateInventorySlot()
    {
        for (int i = 3; i < PagingUtil.GetTotalPage(slots.Length, 3); i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Instantiate(slotPrefab, itemSlotList.transform);
            }
        }
        slots = itemSlotList.GetComponentsInChildren<UISlot>();
    }

    public void UpdateItemCountText(int number)
    {
        itemCountText.text = number.ToString();
    }
}
