using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.UI;
using System.Resources;

public class HermonyData : MonoBehaviour
{
    public int harmonyPoints = 0; // Current harmony points
      public UnityEngine.UI.Text HarmoneyPointsText;// Reference to the UI Text element
    ResorceManager resorceManager;

    // Define types of decorations (customize as needed)
    public enum DecorationType
    {
        Flower,
        stump,
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
            case DecorationType.stump:
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

       int cost = GetDecourationCost(decorationType);
       bool deductionSuccessful =resorceManager.DeductResources(cost);

      if (deductionSuccessful)
    {
        harmonyPoints += contribution;
        // Update UI or perform other actions based on harmony points
        UpdateUI();
    }
     else
    {
        // Handle insufficient resources (e.g., display a message to the player)
        Debug.Log("Insufficient resources to place this decoration.");
    }
    }

    // Update UI to display harmony points
    private void UpdateUI()
    {
        if (HarmoneyPointsText != null)
        {
           HarmoneyPointsText.text = "Harmony Points: " + harmonyPoints;
        }
    }
     private int GetDecourationCost(DecorationType decorationType)
    {
    // Customize the cost based on the decoration type
       switch(decorationType)
      {
         case DecorationType.Flower:
            return 10;
        case DecorationType.Statue:
          return 20;
        case DecorationType.stump:
          return 30;

          default:
            return 0;
      }
    }
    private void AddHarmonyPoints(int pointsToAdd)
    {
        // Add additional logic here if needed
        harmonyPoints += pointsToAdd;

        // You can perform other actions based on the addition of harmony points
        Debug.Log("Additional harmony points added: " + pointsToAdd);
    }
}

