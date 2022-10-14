
using UnityEngine;

public class Key : MonoBehaviour,PickableAbstract
{
    public float keyNumber;
    void Start()
    {
        
    }

    void Update()
    {
        if (Vector3.Distance(this.transform.position, GameObject.Find("Player").transform.position) < 5)
        {
            PickUpObject();
        }
    }

    public void PickUpObject() 
    {
        
        if (Input.GetKey(KeyCode.E))
        {
            Inventory.instance.appendItemToInventory(this);
            destroyObject();
        }
    }

    public void destroyObject()
    {
        Destroy(gameObject);
    }


}
