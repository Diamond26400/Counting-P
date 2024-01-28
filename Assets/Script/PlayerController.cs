using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera; // Reference to the player's camera
    
    [SerializeField] float rotationSpeed = 5.0f;

    void Update()
    {
        // Get the horizontal and vertical input axes
        float horizontalInput = Input.GetAxis("Horizontal");
      

        // Calculate the rotation angles
        float yawAngle = horizontalInput * rotationSpeed * Time.deltaTime;
        

     
        }


    }

    

