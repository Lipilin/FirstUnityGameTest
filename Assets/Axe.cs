using UnityEngine;

public class Axe : MonoBehaviour, PickableAbstract
{
    private bool isInHand = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (Vector3.Distance(this.transform.position, GameObject.Find("Player").transform.position) < 5 && isInHand==false)
        {
            PickUpObject();
        }
        if (isInHand == true && Input.GetKey(KeyCode.Mouse0))
        {

        }
    }

    public void PickUpObject()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Inventory.instance.appendItemToInventory(this);
            isInHand = true;
            destroyObject();
        }
    }

    public void destroyObject()
    {
        transform.position = GameObject.Find("Player_hand").transform.position;
        transform.rotation=GameObject.Find("Player_hand").transform.rotation;
        transform.Rotate(180f, 90f, 0f);
        transform.parent = GameObject.Find("Player").transform;
    }

}
