using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> items = new List<Item>();


    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
   public  void Add(Item item)
    {
        items.Add(item);
    }
    public void Remove(Item item)
    {
        items.Remove(item);
    }
}
