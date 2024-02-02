using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera; // Reference to the player's camera
    
    [SerializeField] float speed = 5.0f;

    void Update()
    {
        // Get the horizontal and vertical input axes
        float horizontalInput = Input.GetAxis("Horizontal");
      
  // Calculate movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        
         // Move the camera
        transform.Translate(movement * speed * Time.deltaTime);
        

     
        }


    }

    

