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

    float Yrotation = 200f;
    float Xrotation = 200f;

    void Update()
    {
        horizontalComponent = Input.GetAxis("Horizontal");
        verticalComponent = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalComponent, 0f, verticalComponent);
        movement.Normalize();
        transform.Translate(movement * speed * Time.deltaTime);

        // Rotate camera on the x-axis
        float W = Input.GetKey(KeyCode.W) ? rotationSpeed * Input.GetAxis("Vertical") * Time.deltaTime : 0f;
        float S = Input.GetKey(KeyCode.S) ? rotationSpeed * -Input.GetAxis("Vertical") * Time.deltaTime : 0f;

        Xrotation += W;
        Yrotation += S;
        transform.Rotate(Vector3.right, W + S);

        // Rotate camera around the y-axis
        float currentRotation = transform.eulerAngles.y;
        float newRotation = currentRotation;

        if (Input.GetKey(KeyCode.A))
        {
            newRotation -= rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            newRotation += rotationSpeed * Time.deltaTime;
        }

        transform.rotation = Quaternion.Euler(0, newRotation, 0);

        // Calculate the spawn point in front of the camera
        Vector3 spawnPoint = playerCamera.transform.position + playerCamera.transform.forward * spawnDistance;

        // Adjust the spawn point to be at the same height as the camera
        spawnPoint.y = playerCamera.transform.position.y;
    }
}
   
