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
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the rotation angles
        float yawAngle = horizontalInput * rotationSpeed * Time.deltaTime;
        float pitchAngle = verticalInput * rotationSpeed * Time.deltaTime;

        // Apply rotation to the camera's transform based on keys
        if (Input.GetKey(KeyCode.A))
        {
            playerCamera.transform.Rotate(Vector3.up, -yawAngle, Space.Self);  // Yaw rotation left
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerCamera.transform.Rotate(Vector3.up, yawAngle, Space.Self);   // Yaw rotation right
        }

        if (Input.GetKey(KeyCode.W))
        {
            playerCamera.transform.Rotate(Vector3.left, pitchAngle, Space.Self);  // Pitch rotation up
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerCamera.transform.Rotate(Vector3.left, -pitchAngle, Space.Self); // Pitch rotation down
        }
    }

    
}
