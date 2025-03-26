using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
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
    
    private UISlot[] slots;

    private void Awake()
    {
        slots = itemSlotList.GetComponentsInChildren<UISlot>();
    }

    private void Start()
    {
        InventoryButton.onClick.AddListener(UIManager.Instance._main.OnInventoryButtonClick);
        UpdateInventorySlot();
        UIManager.Instance.HideInventory();
    }

    public void Init()
    {

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
}
