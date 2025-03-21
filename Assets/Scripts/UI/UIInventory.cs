using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private Button InventoryButton;

    private void Start()
    {
        InventoryButton.onClick.AddListener(UIManager.Instance._main.OnInventoryButtonClick);
    }
}
