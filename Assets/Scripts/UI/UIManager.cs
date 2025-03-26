using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static UIManager _instance;
    public static UIManager Instance { get { return _instance; } }

    public UIStatus _status;

    public UIMain _main;

    public UIInventory _inventory;

    public Player player;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if(_instance != null)
        {
            Destroy(_instance);
        }
    }

    private void Start()
    {
        _main.Init();
        _main.SetPlayerInfo(player);
    }

    public void ShowInventory()
    {
        _inventory.gameObject.SetActive(true);
    }

    public void ShowStatus()
    {
        _status.gameObject.SetActive(true);
    }

    public void HideInventory()
    {
        _inventory.gameObject.SetActive(false);
    }

    public void HideStatus()
    {
        _status.gameObject.SetActive(false);
    }
}
