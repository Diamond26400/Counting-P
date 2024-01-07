using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
   public float horizontalInput;
   public float verticalInput;
   public  float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput =  Input.GetAxis("Vertical");

        transform.Translate( Vector3.forward *verticalInput * speed * Time.deltaTime);
        transform.Translate( Vector3.left *horizontalInput * speed * Time.deltaTime);
    }
}
