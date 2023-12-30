using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemPickUp : MonoBehaviour
{
    public Item item;
    public void Pickup()
    {
        InventoryManager.Instance.Add(item);
    }
    public void OnMouseDown()
    {
        Pickup();
    }
}

