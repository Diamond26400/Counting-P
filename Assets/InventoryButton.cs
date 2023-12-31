using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject Flowers_01;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void spawnObject()
    {
        Instantiate(Flowers_01, transform.position, Quaternion.identity);
    }
}
