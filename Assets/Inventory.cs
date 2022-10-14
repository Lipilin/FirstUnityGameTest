using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<PickableAbstract> currentInventory = new List<PickableAbstract> ();
    public static Inventory instance { get; private set; }

    void Start()
    {
    }

    void Update()
    {
        
    }

    private void Awake()
    {
        if (instance is null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
            
    }

    public bool findItemIfExists(PickableAbstract appropriateItem)
    {
        foreach(var item in Inventory.instance.currentInventory)
        {
            if (item == appropriateItem)
            {
                return true;
            }
        }

        return false;
    }

    public void appendItemToInventory(PickableAbstract item)
    {
        Inventory.instance.currentInventory.Add(item);
    }
}
