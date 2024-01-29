using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryPlacement : MonoBehaviour
{
    public LayerMask groundLayerMask;

    private GameObject inventroyPreferb;
    private GameObject toInventory;
    private Camera mainCam;

    private Ray ray;
    private RaycastHit hit;
    // Start is called before the first frame update
    void Awake()
    {
        mainCam = Camera.main;
        inventroyPreferb = null;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (inventroyPreferb != null)
        {
            //if in build mode
            ray = mainCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit , 1000f,groundLayerMask))
            {
                 toInventory.transform.position = hit.point;
            }
        }
    }
    public void setInventoryPreferb( GameObject preferb)
    {
        inventroyPreferb = preferb;
        PrepareInventory();
    }
    private void PrepareInventory ()
    {
        if ( toInventory) Destroy (  inventroyPreferb);

        toInventory = Instantiate( inventroyPreferb);
       toInventory.SetActive(false);
        
    }
}  
