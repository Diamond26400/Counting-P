using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public Item item;
    // Start is called before the first frame update
    void Pickup()
    {
        InventoryManager.Instance.Add(item);
    }
    public void OnMouseDown()
    {
        Pickup();
    }
}
