using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> items = new List<Item>();
    public GameObject itemPrefab; // Reference to the item prefab
    public Transform inventoryPanel; // Reference to the inventory panel

    private GameObject selectedPrefab; // The currently selected item prefab

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        selectedPrefab = itemPrefab; // For simplicity, assume the same prefab is selected every tim
    }

    // Update is called once per frame
    public void Add(Item item)
    {
        items.Add(item);
    }
    public void Remove(Item item)
    {
        items.Remove(item);
    }
    public void SpawnItem()
    {
        Instantiate(itemPrefab, inventoryPanel);
    }
    public void SpawnItem(Vector3 spawnPoint)
    {
        if (selectedPrefab != null)
        {
            Instantiate(selectedPrefab, spawnPoint, Quaternion.identity);
            Debug.Log("Item spawned at: " + spawnPoint);
        }
        else
        {
            Debug.LogWarning("No item selected.");
        }
    }
}





