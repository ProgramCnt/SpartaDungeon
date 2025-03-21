using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField]
    private Button StatusButton;

    private void Start()
    {
        StatusButton.onClick.AddListener(UIManager.Instance._main.OnStatusButtonClick);
    }
}
