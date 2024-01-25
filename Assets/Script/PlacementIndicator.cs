using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlacementIndicator : MonoBehaviour
{
  public Transform playerCamera; // Player's camera
    public LayerMask placementLayer; // Layer for valid placement surfaces
    public float maxDistance = 5f; // Maximum distance for raycasting

    private GameObject placementIndicator; // Reference to the instantiated placement indicator

    // Prefabs for different objects
    public GameObject flowerIndicatorPrefab;
    public GameObject stumpIndicatorPrefab;
    public GameObject statueIndicatorPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Placeholder for selecting the object type from the inventory
            // For demonstration purposes, let's assume the player selects the Flower type
            SelectObjectType(ObjectType.Flower);
        }

        if (placementIndicator != null)
        {
            UpdatePlacementIndicator();
        }
    }

    void SelectObjectType(ObjectType objectType)
    {
        // Instantiate the corresponding indicator prefab based on the selected object type
        switch (objectType)
        {
            case ObjectType.Flower:
                placementIndicator = Instantiate(flowerIndicatorPrefab);
                break;
            case ObjectType.Stump:
                placementIndicator = Instantiate(stumpIndicatorPrefab);
                break;
            case ObjectType.Statue:
                placementIndicator = Instantiate(statueIndicatorPrefab);
                break;
            // Add more cases for additional object types
        }
    }

    void UpdatePlacementIndicator()
    {
        // Raycast from the player's camera to determine the placement position
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out RaycastHit hit, maxDistance, placementLayer))
        {
            // Position the placement indicator at the hit point with a slight offset
            placementIndicator.transform.position = hit.point + hit.normal * 0.1f;
            placementIndicator.transform.rotation = Quaternion.LookRotation(hit.normal);
        }
    }

    // Enumeration representing different object types
    public enum ObjectType
    {
        Flower,
        Stump,
        Statue
        // Add more types as needed
    }
}