using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Progress;

public class GardenInputController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] ItemDragAndDrop itemDragAndDrop;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //for pc
        if (Input.GetMouseButtonDown(0))
        {
            HandleInput(Input.mousePosition);
        }
        //for mobile
        else if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            HandleInput(touch.position);
        }

        void HandleInput(Vector3 inputPosition)
        {
            // Convert screen point to world point
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(inputPosition.x, inputPosition.y, 10f));

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


        void OnInputBegin(Vector3 position)
        {
            // Implement logic for the beginning of the input (e.g., selecting an item from the inventory)
            Debug.Log("Input Begin at: " + position);
        }
        void OnInputHold(Vector3 position)
        {
            // Implement logic for holding the input (e.g., dragging and placing items in the garden)
           

            Debug.Log("Input Hold at: " + position);
        }
        void OnInputEnd(Vector3 position)
        {
            // Implement logic for the end of the input(e.g., finalizing the placement of an item)
            Debug.Log("Input Hold at: " + position);
        }


    }
}
