using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Progress;

public class GardenInputController : MonoBehaviour
{
    public GameObject pointerPrefab; // Prefab for the pointer object
    private GameObject pointerInstance; // Instance of the pointer

    private Camera mainCamera;

    private void Start()
    {
        // Get the main camera
        mainCamera = Camera.main;

        // Instantiate the pointer
        pointerInstance = Instantiate(pointerPrefab, Vector3.zero, Quaternion.identity);
        pointerInstance.SetActive(false); // Initially hide the pointer
    }

    private void Update()
    {
        // Check for mouse or touch input
        if (Input.GetMouseButton(0)) // For PC
        {
            HandleInput(Input.mousePosition);
        }
        else if (Input.touchCount > 0) // For mobile
        {
            Touch touch = Input.GetTouch(0);
            HandleInput(touch.position);
        }
    }

    private void HandleInput(Vector2 inputPosition)
    {
        // Convert screen point to world point
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(inputPosition.x, inputPosition.y, 10f));

        // Update the position of the pointer
        pointerInstance.transform.position = new Vector3(worldPosition.x, worldPosition.y, 0f);

        // Perform actions based on the input
        if (Input.GetMouseButtonDown(0) || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            OnInputBegin(worldPosition);
        }
        else if (Input.GetMouseButton(0) || Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            OnInputHold(worldPosition);
        }
        else if (Input.GetMouseButtonUp(0) || Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            OnInputEnd(worldPosition);
        }
    }

    private void OnInputBegin(Vector3 position)
    {
        // Placeholder: Log a message for demonstration purposes
        Debug.Log("Input Begin at: " + position);

        // Show the pointer when input begins
        pointerInstance.SetActive(true);
    }

    private void OnInputHold(Vector3 position)
    {
        // Placeholder: Log a message for demonstration purposes
        Debug.Log("Input Hold at: " + position);
    }

    private void OnInputEnd(Vector3 position)
    {
        // Placeholder: Log a message for demonstration purposes
        Debug.Log("Input End at: " + position);

        // Hide the pointer when input ends
        pointerInstance.SetActive(false);
    }
}
