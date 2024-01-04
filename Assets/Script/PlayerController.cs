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
    [SerializeField] float maxLookUp = 80f; // Maximum allowed look up angle
    [SerializeField] float maxLookDown = 80f; // Maximum allowed look down angle

    private void Start()
    {
        // Remove Update() call from Start() as Update is automatically called each frame.
    }

    public void Update()
    {
        horizontalcomponent = Input.GetAxis("Horizontal");
        verticalComponent = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalcomponent, 0f, verticalComponent);
        movement.Normalize();
        transform.Translate(movement * speed * Time.deltaTime);

        // Rotate up (pitch) when W is held down
        if (Input.GetKey(KeyCode.W))
        {
            RotateCamera(-rotationSpeed);
        }

        // Rotate down (pitch) when S is held down
        if (Input.GetKey(KeyCode.S))
        {
            RotateCamera(rotationSpeed);
        }

        // Get mouse input for rotation
        // float mouseX = Input.GetAxis("Mouse X");
        // float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the camera vertically (pitch)
        // RotateCamera(mouseY * rotationSpeed);

        // Rotate the entire player horizontally (yaw)
        // transform.Rotate(Vector3.up * mouseX * rotationSpeed);
    }

    private void RotateCamera(float amount)
    {
        // Rotate the camera's local rotation around the x-axis (pitch)
        float newRotationX = playerCamera.transform.localRotation.eulerAngles.x + amount * Time.deltaTime;
        newRotationX = Mathf.Clamp(newRotationX, -maxLookUp, maxLookDown);
        playerCamera.transform.localRotation = Quaternion.Euler(newRotationX, 0f, 0f);
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

