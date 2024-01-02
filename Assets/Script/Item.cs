using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]

public class Item : ScriptableObject
{
    // Start is called before the first frame update
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;

    // Update is called once per frame
    void Update()
    {

    }
}