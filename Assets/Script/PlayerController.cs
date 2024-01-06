using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera; // Reference to the player's camera

    public float spawnDistance = 2;
    public float horizontalComponent;
    public float verticalComponent;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 5.0f;
    
    float yawAngle = 0f;
float pitchAngle = 0f;

    float Yrotation = 200f;
    float Xrotation = 200f;

    void Update()
    {
        // basic movement
        horizontalComponent = Input.GetAxis("Horizontal");
        verticalComponent = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalComponent, 0f, verticalComponent);
        movement.Normalize();
        transform.Translate(movement * speed * Time.deltaTime);

// Get the horizontal and vertical input axes
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");


//keys
if(Input.GetKey(KeyCode.W)){

    float yawAngle = horizontalInput * speed * Time.deltaTime;

}
else if (Input.GetKey(KeyCode.S)){
    float yawAngle = -horizontalInput * speed * Time.deltaTime;
    
}
    // Calculate the rotation angles
  if(Input.GetKey(KeyCode.A))
  {
    float pitchAngle = verticalInput * speed * Time.deltaTime;
    
  }
  else if(Input.GetKey(KeyCode.D))
  {
     float pitchAngle = -verticalInput * speed * Time.deltaTime;

         
  }
 
   


    // Rotate the camera around its own axis

     }
}
   
