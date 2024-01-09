using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HermonyData : MonoBehaviour
{
    public int harmonyPoints = 0; // Current harmony points

    // Define types of decorations (customize as needed)
    public enum DecorationType
    {
        Flower,
        Bench,
        Statue
        // Add more types as per your game
    }

    // Sample rule: Define how certain decoration combinations affect harmony
    public int GetHarmonyContribution(DecorationType decorationType)
    {
        switch (decorationType)
        {
            case DecorationType.Flower:
                return 2; // Example: Flowers contribute positively
            case DecorationType.Bench:
                return 1; // Example: Benches contribute less
            case DecorationType.Statue:
                return -3; // Example: Statues might conflict
            default:
                return 0; // No contribution for unknown types
        }
    }

    // Update harmony points based on the placement of a new decoration
    public void UpdateHarmonyPoints(DecorationType decorationType)
    {
        int contribution = GetHarmonyContribution(decorationType);
        harmonyPoints += contribution;

        // Update UI or perform other actions based on harmony points
        UpdateUI();
    }

    // Update UI to display harmony points
    private void UpdateUI()
    {
        // Implement UI update logic here
        Debug.Log("Current Harmony Points: " + harmonyPoints);
    }
}

