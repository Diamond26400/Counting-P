using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlacementIndicator : MonoBehaviour
{
    public Transform playerCamera; // Player's camera
    public LayerMask placementLayer; // Layer for valid placement surfaces
    public float maxDistance = 5f; // Maximum distance for raycasting
    public GameObject indicatorPrefab; // Prefab or model for the placement indicator

    private GameObject placementIndicator; // Reference to the instantiated placement indicator

    void Update()
    {
        // Raycast from the player's camera to determine the placement position
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out RaycastHit hit, maxDistance, placementLayer))
        {
            // If the placement indicator doesn't exist, instantiate it
            if (placementIndicator == null)
            {
                placementIndicator = Instantiate(indicatorPrefab);
            }

            // Position the placement indicator at the hit point with a slight offset
            placementIndicator.transform.position = hit.point + hit.normal * 0.1f;
            placementIndicator.transform.rotation = Quaternion.LookRotation(hit.normal);
        }
        else
        {
            // If no valid surface is hit, deactivate the placement indicator
            if (placementIndicator != null)
            {
                Destroy(placementIndicator);
            }
        }
    }
}
