using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject decouration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void spawnObject()
    {
        Instantiate(decouration, transform.position, Quaternion.identity);
    }
}
