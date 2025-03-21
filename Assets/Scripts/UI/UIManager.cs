using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static UIManager _instance;
    public static UIManager Instance { get { return _instance; } }

    [SerializeField]
    private UIStatus _status;

    [SerializeField]
    private UIMain _main;

    [SerializeField]
    private UIInventory _inventory;

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
        
    }
}
