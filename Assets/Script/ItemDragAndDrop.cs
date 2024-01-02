using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemDragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void Update()
    {
        if (isDragging)
        {
            // Update the position during drag
            Vector3 newPosition = GetInputPosition();
            transform.position = newPosition;
        }
    }

    private void OnMouseDown()
    {
        // Record the offset between the object's position and the input position
        offset = transform.position - GetInputPosition();
        isDragging = true;
    }

    private void OnMouseDrag()
    {
        // Continue dragging while the mouse is held down
        Vector3 newPosition = GetInputPosition() + offset;
        transform.position = newPosition;
    }

    private void OnMouseUp()
    {
        // Stop dragging when the mouse is released
        isDragging = false;

        // Perform additional actions, e.g., snap to grid, check for valid placement, etc.
        // You can add your logic here.
    }

    private Vector3 GetInputPosition()
    {
        // Get the current input position (mouse or touch)
        Vector3 inputPosition;

        if (Input.touchCount > 0)
        {
            inputPosition = Input.GetTouch(0).position;
        }
        else
        {
            inputPosition = Input.mousePosition;
        }

        // Convert screen space to world space
        inputPosition = Camera.main.ScreenToWorldPoint(inputPosition);
        inputPosition.z = 0f; // Ensure the object stays in the 2D plane

        return inputPosition;
    }
}
