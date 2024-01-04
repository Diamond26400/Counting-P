using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera; // Reference to the player's camera

    // Adjust the offset to determine the spawn position in front of the camera
    public float spawnDistance = 2f;

    public float horizontalcomponent;
    public float verticalComponent;
   [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 5.0f;
    private void Start()
    {
        
        Update();
    }
    public void Update()
    {
        horizontalcomponent = Input.GetAxis("Horizontal");
        verticalComponent = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalcomponent, 0f, verticalComponent);
        movement.Normalize();
        transform.Translate(movement * speed * Time.deltaTime);

        // Get mouse input for rotation
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the camera vertically (pitch)
        transform.Rotate(Vector3.left * mouseY * rotationSpeed);

        // Rotate the entire player horizontally (yaw)
        transform.parent.Rotate(Vector3.up * mouseX * rotationSpeed);
    }
    public Vector3 GetSpawnPoint()
    {
        // Calculate the spawn point in front of the camera
        Vector3 spawnPoint = playerCamera.transform.position + playerCamera.transform.forward * spawnDistance;

        // Adjust the spawn point to be at the same height as the camera
        spawnPoint.y = playerCamera.transform.position.y;


    
        return spawnPoint;
    }
    
}
