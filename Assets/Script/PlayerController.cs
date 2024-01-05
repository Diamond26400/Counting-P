using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera; // Reference to the player's camera

    public float spawnDistance = 2;
    public float horizontalcomponent;
    public float verticalComponent;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 5.0f;
    public Transform Camera;

    float  Yrotation = 200f;
    float Xrotation  = 200f;
    private void Start()
    {

    }

    public void Update()
    {
        horizontalcomponent = Input.GetAxis("Horizontal");
        verticalComponent = Input.GetAxis("Vertical");

       
        Vector3 movement = new Vector3(horizontalcomponent, 0f, verticalComponent);
        movement.Normalize();
        transform.Translate(movement * speed * Time.deltaTime);


        //rotate camera on the x-axis
          float Current = transform.eulerAngles.x;

        float W = Input.GetKey(KeyCode.W) ? rotationSpeed *Input.GetAxis("Vertical")* Current*Time.deltaTime : 0f;
        float S = Input.GetKey(KeyCode.S) ? rotationSpeed  * -Input.GetAxis("Vertical") *Current * Time.deltaTime : 0f;

        Xrotation += W;
        Yrotation += S;
        transform.Rotate(Vector3.right, W + S) ;

        float CurrentPosition = transform.eulerAngles.y;
         float newRotation = CurrentPosition;
         if (Input.GetKey(KeyCode.A))
         {
            newRotation -= rotationSpeed * Time.deltaTime;
         }
         else if (Input.GetKey(KeyCode.D))
         {
           newRotation += rotationSpeed * Time.deltaTime;

         }


        transform.rotation = Quaternion.Euler(Current,newRotation,0);



      //transform.localRotation = Quaternion.Euler(Xrotation, Yrotation, 0f);
       // transform.Rotate (Vector3.right , W * rotationSpeed *Time.deltaTime);
        Vector3 GetSpawnPoint()
        {
            // Calculate the spawn point in front of the camera
            Vector3 spawnPoint = playerCamera.transform.position + playerCamera.transform.forward * spawnDistance;

            // Adjust the spawn point to be at the same height as the camera
            spawnPoint.y = playerCamera.transform.position.y;

            return spawnPoint;
        }
    }
}
   
