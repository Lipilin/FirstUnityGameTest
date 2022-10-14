using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Door : MonoBehaviour
{
    public float doorNumber;

    void Start()
    {
        
    }

    void Update()
    {
        if(Vector3.Distance(this.transform.position, GameObject.Find("Player").transform.position)<5 & Input.GetKey(KeyCode.E))
        {
            tryToOpenDoor();
        }
    }

    void tryToOpenDoor()
    {
        foreach (Key item in Inventory.instance.currentInventory.OfType<Key>().ToList())
        {
            if (item is Key && item.keyNumber==this.doorNumber)
            {
                openDoor();
                return;
            }
        }
    }

    void openDoor()
    {
        transform.eulerAngles += new Vector3(0.0f, -150.0f, 0.0f);
        Destroy(this);
        return;
    }


}
