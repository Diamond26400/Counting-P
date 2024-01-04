using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera; // Reference to the player's camera

    // Adjust the offset to determine the spawn position in front of the camera
    public float spawnDistance = 2f;

    // ... other player controller code

    public Vector3 GetSpawnPoint()
    {
        // Calculate the spawn point in front of the camera
        Vector3 spawnPoint = playerCamera.transform.position + playerCamera.transform.forward * spawnDistance;

        // Adjust the spawn point to be at the same height as the camera
        spawnPoint.y = playerCamera.transform.position.y;

        return spawnPoint;
    }
}
