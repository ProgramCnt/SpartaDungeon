using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField]
    private Image ItemImage;

    [SerializeField]
    private TextMeshProUGUI equipedText;

    public ItemData itemData = null;

    public void SetItem(ItemData itemData)
    {
        this.itemData = itemData;
    }

    public void RefreshUI()
    {
        if (itemData != null)
        {
            ItemImage.sprite = itemData.ItemImage;
            ItemImage.color = new Color(1f,1f,1f,1f);
        }
    }
}
